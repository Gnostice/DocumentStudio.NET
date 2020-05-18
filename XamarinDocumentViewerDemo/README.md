# Document Studio .NET
Gnostice Document Studio .NET is the next-generation .NET Core compliant multi-format document-processing component suite for .NET developers. It has controls for viewing, printing, and converting PDF, DOCX, DOC, HTML, TXT, XLSX, XLS, ODS, XPS, BMP, JPEG, PNG, WMF, EMF, TIFF and MTIFF. Gnostice Document Studio comes with advanced multi-format document viewer controls for Xamarin, WinForms, WPF, and ASP.NET (WebForms and MVC).

# Xamarin Document Viewer control demo project
The multi-format Document Viewer control for Xamarin easily allows you to add document viewing capability to your mobile apps. The viewer supports viewing of PDF, DOCX, DOC, TXT, XLSX, XLS, ODS, BMP, JPEG, GIF and PNG files. Unique features of the viewer include multiple page layouting and unlimited zoom. The viewer now supports text search, text selection and copy to clipboard features.

This is a C# demo project of the document viewer in action. 

# Text Search API
The API to search for text in the document that is currently loaded in the viewer is shown below. 

```
// Search for text in the forward direction starting from either the current cursor position or the position of the last search occurrence.
// Parameters:
//   searchText - The text string to look for.
//   textSearchMode - The text search mode. Whether to perform literal search (TextSearchMode.Literal) or pattern search using regex (TextSearchMode.Regex).
//   searchOptions - Text search options.
//   lastSearchResult - The result of the last search operation to continue the search from there or null if the search should start at the current cursor position.
// Return:
//   Details of the search text occurrence or null if no more occurrences of the search text could be found.
public TextSearchResult FindNext(string searchText, TextSearchMode textSearchMode = TextSearchMode.Literal, TextSearchOptions searchOptions = TextSearchOptions.None, TextSearchResult lastSearchResult = null);

// Search for text in the reverse direction starting from either the current cursor position or the position of the last search occurrence.
// Parameters:
//   searchText - The text string to look for.
//   textSearchMode - The text search mode. Whether to perform literal search (TextSearchMode.Literal) or pattern search using regex (TextSearchMode.Regex).
//   searchOptions - Text search options.
//   lastSearchResult - The result of the last search operation to continue the search from there or null if the search should start at the current cursor position.
// Return:
//   Details of the search text occurrence or null if no more occurrences of the search text could be found.
public TextSearchResult FindPrevious(string searchText, TextSearchMode textSearchMode = TextSearchMode.Literal, TextSearchOptions searchOptions = TextSearchOptions.None, TextSearchResult lastSearchResult = null);

```
