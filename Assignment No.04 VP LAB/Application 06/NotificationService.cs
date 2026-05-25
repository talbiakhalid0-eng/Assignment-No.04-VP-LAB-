namespace Assignment_No._04_VP_LAB.Application_06
{
    public class NotificationService
    {
		private readonly NotificationConfig _globalConfiguration;
		public NotificationService(NotificationConfig configuration) => _globalConfiguration = configuration;

		public Task<List<string>> ExtractActiveSystemLogsAsync()
		{
			var outputContainer = new List<string>();
			for (int i = 1; i <= _globalConfiguration.DefaultNumberOfNotifications; i++)
			{
				outputContainer.Add($"[Registry Frame Broadcast Engine 0{i}]: Subsystem thread node metrics mapping completely balanced.");
			}
			return Task.FromResult(outputContainer);
		}
	}
}
