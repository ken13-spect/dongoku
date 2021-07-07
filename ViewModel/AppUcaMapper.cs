using AppUCA.Entities;

namespace AppUCA.ViewModel
{
    public static class AppUcaMapper
    {
        public static InscriptionsVm MapInscriptionsToIncriptionVm(Inscription e)
        {
            return new InscriptionsVm
            {
                FullName = e.FullName,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber

            };
        }
        
        public static CourseVm MapCourseToCourseVm(Course e)
        {
            return new CourseVm
            {
                Id = e.Id,
                Title = e.Title,
                Modules = e.Modules,
                Topic = e.Topic,
                Author = e.Author,
                Duration = e.Duration,
                Schedule = e.Schedule
              

            };
        }
    }
}