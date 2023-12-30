using Microsoft.AspNetCore.Mvc;

namespace _213002_Assignment05.ViewComponents
{
    [ViewComponent(Name = "Simple")]
    public class SimpleViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke(string additionalData)
        {
            var data = GetSampleData(additionalData);
            return View(data);
        }

        private List<string> GetSampleData(string additionalData)
        {
            List<string> data = new List<string>();
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            data.Add("Four");
            data.Add(additionalData);
            return data;
        }
    }
}
