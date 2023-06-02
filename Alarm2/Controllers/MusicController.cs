using Microsoft.AspNetCore.Mvc;
using System.Media;

namespace Alarm2.Controllers
{
    public class MusicController : Controller
    {
        private readonly string musicFilePath = @"C:\Users\PreshenR\Desktop\App Support\Alarm2\Alarm2\wwwroot\Music\Alarm.wav";
        private readonly SoundPlayer soundPlayer;
        public MusicController()
        {
            soundPlayer = new SoundPlayer(musicFilePath);
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Play()
        //{
        //    soundPlayer.Play();
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Stop()
        //{
        //    soundPlayer.Stop();
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Play()
        //{
        //    soundPlayer.Play();
        //    return Content("Sound is playing");
        //}

        //public IActionResult Stop()
        //{
        //    soundPlayer.Stop();
        //    return Content("Sound stopped");
        //}

        [HttpPost]
        public IActionResult Play(string inputValue)
        {
            if (inputValue == "1")
            {
                soundPlayer.Play();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Please enter 1 to play the sound.";
                return View("Index");
            }
        }

        public IActionResult Stop()
        {
            soundPlayer.Stop();
            return RedirectToAction("Index");
        }


    }
}
