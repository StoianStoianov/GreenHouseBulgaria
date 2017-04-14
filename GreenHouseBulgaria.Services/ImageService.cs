using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouseBulgaria.Data.Repositories;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Services.Contracts;

namespace GreenHouseBulgaria.Services
{
    public class ImageService : IImageService
    {
        private IRepository<Image> imageRepository;

        public ImageService(IRepository<Image> imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        public void Add(Image image)
        {
            this.imageRepository.Add(image);
            this.imageRepository.SaveChanges();
        }

        public void Delete(Image image)
        {
           this.imageRepository.Delete(image);
            this.imageRepository.SaveChanges();
        }
    }
}
