<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ASP.NET_Web_Converter._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblUploadFiles" runat="server" Font-Bold="True" Text="Upload Files to Convert:"></asp:Label>
            </td>
            <td>
                <asp:FileUpload ID="flUpld" multiple runat="server" />
            </td>
            <td>
                <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Uploaded Files">
                <table width="100%">
                    <tr>
                        <td rowspan="4" width="95%">
                            <asp:DropDownList ID="ddlInputFiles" runat="server"
                                onchange="return EnableOrDisable()" size="5" Width="100%">
                            </asp:DropDownList>
                        </td>
                        <td width="5%">
                            <asp:Button ID="btnRemove" runat="server" Enabled="False" Height="22px"
                                OnClick="btnRemove_Click" Text="Remove" Width="82px" />
                        </td>
                    </tr>
                    <tr>
                        <td width="5%">
                            <asp:Button ID="btnUp" runat="server" Enabled="False" Height="22px"
                                OnClick="btnUp_Click" Text="Move Up" Width="82px" />
                        </td>
                    </tr>
                    <tr>
                        <td width="5%">
                            <asp:Button ID="btnDown" runat="server" Enabled="False" Height="22px"
                                OnClick="btnDown_Click" Text="Move Down" Width="82px" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Panel ID="Panel2" runat="server" GroupingText="Output">
        <table>
            <tr>
                <td>Format
                </td>
                <td>Base File Name
                </td>
                <td>Conversion Mode</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlOutputFormat" runat="server" onchange="showHideChkBx()" ClientIDMode="Static">
                        <asp:ListItem>PDF</asp:ListItem>
                        <asp:ListItem>DOCX</asp:ListItem>
                        <asp:ListItem>BMP</asp:ListItem>
                        <asp:ListItem>JPEG</asp:ListItem>
                        <asp:ListItem>PNG</asp:ListItem>
                        <asp:ListItem>TIFF Single Page</asp:ListItem>
                        <asp:ListItem>TIFF Multipage</asp:ListItem>
                        <asp:ListItem>TXT</asp:ListItem>
                        <asp:ListItem>HTML</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtBaseFileName" size="40" runat="server" Width="124px"></asp:TextBox>
                </td>
                <td>
                    <asp:DropDownList ID="cmbConversionMode" runat="server" Width="189px" onchange="showHideChkBx()" ClientIDMode="Static">
                        <asp:ListItem>Convert To Single File</asp:ListItem>
                        <asp:ListItem>Convert To Seperate Files</asp:ListItem>
                        <asp:ListItem>Convert First File And Attach Rest As Original</asp:ListItem>
                        <asp:ListItem>Create New File And Attach All As Original</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <label style="display: none;" id="lblCreatePortfolio">
                        <asp:CheckBox ID="chkCreatePortfolio" runat="server" Checked="true" />Create Portfolio</label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" GroupingText="Start Conversion">
        <table width="100%">
            <tr>
                <td align="center">
                    <asp:Button ID="btnConvert" runat="server" Text="Start" Height="64px" Width="392px"
                        Font-Bold="True" Font-Size="XX-Large" ForeColor="Green" Enabled="False" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <center>
        <asp:HyperLink ID="outputlink" Visible="false" runat="server">Download Converted Files</asp:HyperLink>
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" 
            Text="Error" Visible="False"></asp:Label>
    </center>
    <script type="text/javascript">
        function showHideChkBx() {
            if (document.getElementById("ddlOutputFormat").value == "PDF" && (document.getElementById("cmbConversionMode").value == "Convert First File And Attach Rest As Original" ||
                document.getElementById("cmbConversionMode").value == "Create New File And Attach All As Original")) {
                document.getElementById("lblCreatePortfolio").style.display = "block";
            }
            else {
                document.getElementById("lblCreatePortfolio").style.display = "none";
            }
        }
    </script>
</asp:Content>
