﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
    public class SliderService : ISliderService
    {
        private ISliderDal _sliderDal;

        public SliderService(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IList<Slider> GetAll(string name)
        {
            return _sliderDal.GetAll(x => x.Name == name);
        }
    }

    public interface ISliderService
    {
        IList<Slider> GetAll(string name);
    }
}
