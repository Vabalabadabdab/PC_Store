using AutoMapper;
using BLL_ComputerStore.Infrastucture.Models;
using Domain_ComputerStore.Models;

namespace BLL_ComputerStore.Infrastucture
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<Property, PropertyDTO>();
            CreateMap<GroupReview, GroupReviewDTO>();
            CreateMap<Order, OrderDTO>();
            
            CreateMap<Review, ReviewDTO>();
            CreateMap<GroupReview, GroupReviewDTO>();

            CreateMap<ReviewDTO, Review>();
        }
    }
}
