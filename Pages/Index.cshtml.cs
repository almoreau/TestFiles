using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CheckFiles.Pages
{
    public class IndexModel : PageModel
    {
        public List<DirectoryViewModel>? Directories { get; set; }

        public void OnGet()
        {
            Directories = new List<DirectoryViewModel>
            {
                new DirectoryViewModel
                {
                    Name = "Répertoire 1",
                    Subdirectories = new List<DirectoryViewModel>
                    {
                        new DirectoryViewModel { Name = "Sous-répertoire 1.1" },
                        new DirectoryViewModel { Name = "Sous-répertoire 1.2" }
                    }
                },
                new DirectoryViewModel
                {
                    Name = "Répertoire 2",
                    Subdirectories = new List<DirectoryViewModel>
                    {
                        new DirectoryViewModel { Name = "Sous-répertoire 2.1" },
                        new DirectoryViewModel { Name = "Sous-répertoire 2.2" }
                    }
                }
            };
        }
    }
}
