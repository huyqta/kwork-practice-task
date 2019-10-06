namespace KworkPracticeTask.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly KworkPracticeTaskDbContext _context;

        public InitialHostDbBuilder(KworkPracticeTaskDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
