using Gnostice.Controls.ASP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace PDFSignDemo
{
    public class MyServerEventsHandler : ServerEventsHandler
    {
        // The event arguments for all methods below have the following common properties
        // HttpContext - instance of HttpContext class for the current request

        // Method called when the server starts up
        public override void OnServerStart(OnServerStartEventArgs serverStartEventArgs)
        {
            // serverStartEventArgs.ViewerPreferences contains the preferences for the viewer
            // The preferences need to be set when the server starts up and they cannot be 
            // changed after that
            var viewerPreferences = serverStartEventArgs.ViewerPreferences;

            viewerPreferences.Interactivity.AllowSigning = true;
        }

        public override void AfterDocumentSave(AfterDocumentSaveEventArgs documentSaveEventArgs)
        {
            // Create a list of the user signatures
            List<MySignatureKeyValPair> signatures = new List<MySignatureKeyValPair>();
            foreach (UserSignature userSignature in documentSaveEventArgs.UserSignatures)
            {
                MySignatureKeyValPair sign = new MySignatureKeyValPair
                {
                    Id = userSignature.SignId,
                    Name = userSignature.Name,
                    SignatureImage = userSignature.ImageAsBase64String
                };
                signatures.Add(sign);
            }

            if (signatures.Count > 0)
            {
                // Serialize the signature list to JSON
                StringBuilder builder = new StringBuilder();
                using (StringWriter sw = new StringWriter(builder))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    var scriptSerializer = JsonSerializer.Create(new JsonSerializerSettings());
                    scriptSerializer.Serialize(writer, signatures);
                }

                // Store the JSON in the session cache
                documentSaveEventArgs.HttpContext.Session["mySignatures"] = builder.ToString();
            }
        }

        public override void NeedUserSignatures(NeedUserSignaturesEventArgs needUserSignaturesEventArgs)
        {
            // Check if the session contains signatures stored earlier
            if (needUserSignaturesEventArgs.HttpContext.Session["mySignatures"] != null)
            {
                // Deserialize the JSON to a list of signature objects
                string mySignatures = needUserSignaturesEventArgs.HttpContext.Session["mySignatures"].ToString();
                List<MySignatureKeyValPair> signatures = JsonConvert.DeserializeObject<List<MySignatureKeyValPair>>(mySignatures);
                foreach (var sign in signatures)
                {
                    using (var memStream = new MemoryStream(Convert.FromBase64String(sign.SignatureImage)))
                    {
                        UserSignature signature = new UserSignature(sign.Id, sign.Name, memStream);
                        needUserSignaturesEventArgs.UserSignatures.Add(signature);
                    }
                }
            }
        }
    }
}