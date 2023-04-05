using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class BannerStyleTwoComponentHandler : IBannerStyleTwoComponentHandler
    {
        private ISliderService _sliderService;

        public BannerStyleTwoComponentHandler(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IList<Slider> getSlider()
        {
            return _sliderService.GetAll("home");
        }
    }

    public interface IBannerStyleTwoComponentHandler
    {
        IList<Slider> getSlider();
    }
}
