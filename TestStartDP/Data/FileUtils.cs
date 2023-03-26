using Microsoft.JSInterop;

namespace TestStartDP.Data
{
    public static class FileUtils
    {
        public static async Task<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
            => await js.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}
