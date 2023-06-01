namespace ForgetMeNot.Data
{
    public class NoteService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        public Note CreateNote(string text)
        {
            return new Note
            {
                Text = text,
                CreatedDate = DateTime.UtcNow
            };
        }

        public Task<Note[]> GetNotesAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Note
            {
                CreatedDate = startDate.AddDays(index),
                //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}