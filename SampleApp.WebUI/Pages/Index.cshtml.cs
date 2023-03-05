using SampleApp.Library;

namespace SampleApp.WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string HelloMessage { get; set; } = string.Empty;
        public string ExceptionMessage { get; set; } = string.Empty;
        public DateTime CurrentUtcDateTime { get; set; } = DateTime.UtcNow;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            HelloMessage = new Messages().Hello;
            ExceptionMessage = new InvalidFormatException().Message;
            CurrentUtcDateTime = DateTime.UtcNow;
        }
    }
}