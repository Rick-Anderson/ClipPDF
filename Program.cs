internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        string clipboardText = Clipboard.GetText();

        // Check if there's any text
        if (!string.IsNullOrEmpty(clipboardText))
        {
            // Replace newlines and carriage returns with spaces
            string processedText = clipboardText.Replace("\r\n", " ").Replace("\n", " ");

            // Trim any leading/trailing spaces
            processedText = processedText.Trim();

            Console.WriteLine(processedText);

            Clipboard.SetText(processedText); 
        }
        else
        {
            Console.WriteLine("No text found in clipboard.");
        }
    }
}