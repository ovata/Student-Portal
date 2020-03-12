using System;

namespace Code_360.ViewModels
{
    public class UpdateStudent : StudentViewModel
    {
        public Guid Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
