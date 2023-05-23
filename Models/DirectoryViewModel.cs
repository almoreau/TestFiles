public class DirectoryViewModel
{
    public string Name { get; set; }
    public List<DirectoryViewModel> Subdirectories { get; set; }

    public DirectoryViewModel()
    {
        Subdirectories = new List<DirectoryViewModel>();
    }
}
