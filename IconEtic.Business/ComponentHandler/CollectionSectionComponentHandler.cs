using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class CollectionSectionComponentHandler : ICollectionSectionComponentHandler
    {
        private ISliderService _sliderService;

        public CollectionSectionComponentHandler(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IList<Slider> getSlider()
        {
            return _sliderService.GetAll("slider2");
        }
    }

    public interface ICollectionSectionComponentHandler
    {
        IList<Slider> getSlider();
    }
}
