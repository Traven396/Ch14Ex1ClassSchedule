using Xunit;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;

namespace ClassScheduleTests
{
    public class TeacherControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnAViewResult()
        {
            //If I remember right you said not to use Moq, so idk what we are supposed to do here
            //var techRep = new Repository<Teacher>(ctx);
            //var controller = new TeacherController();
        }
    }
}