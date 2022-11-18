using AutoMapper;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.Accounts;
using PizzaDeliveryServices.DTO.CharacteristicDTO;
using PizzaDeliveryServices.DTO.IngredientDTO;
using PizzaDeliveryServices.DTO.ItemDTO;
using PizzaDeliveryServices.DTO.Order;
using PizzaDeliveryServices.DTO.PizzaBaseDTO;
using PizzaDeliveryServices.DTO.PizzaDTO;
using PizzaDeliveryServices.DTO.PizzaIngredient;
using PizzaDeliveryServices.DTO.PizzaOrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Mapper
{
    public class MapperConfiguration: Profile 
    {
        public MapperConfiguration()
        {
            this.CreateMap<IngredientCreateDTO,Ingredient>()
            .ForMember(_ => _.Name, opt => opt.MapFrom(i => i.Name));

            this.CreateMap<Ingredient, IngredientGetDTO>()
            .ForMember(_ => _.Name, opt => opt.MapFrom(i => i.Name))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id));

            this.CreateMap<PizzaBaseCreateDTO, PizzaBase>()
            .ForMember(_ => _.Name, opt => opt.MapFrom(i => i.Name))
            .ForMember(_ => _.Description, opt => opt.MapFrom(i => i.Description))
            .ForMember(_ => _.PizzaIngredients, opt => opt
            .MapFrom(i => i.Ingredients.Select(_ => new PizzaIngredient { IngredientID = _ })));

            this.CreateMap<PizzaBaseUpdateDTO, PizzaBase>()
            .ForMember(_ => _.Name, opt => opt.MapFrom(i => i.Name))
            .ForMember(_ => _.Description, opt => opt.MapFrom(i => i.Description))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.PizzaIngredients, opt => opt
            .MapFrom(i => i.Ingredients.Select(_ => new PizzaIngredient { IngredientID = _ })));

            this.CreateMap<PizzaIngredientCreateDTO, PizzaIngredient>()
            .ForMember(_ => _.IngredientID, opt => opt.MapFrom(i => i.IngredientID))
            .ForMember(_ => _.PizzaBaseID, opt => opt.MapFrom(i => i.PizzaBaseID));

            this.CreateMap<CharacteristicCreateDTO, Characteristic>()
            .ForMember(_ => _.Diameter, opt => opt.MapFrom(i => i.Diameter))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price))
            .ForMember(_ => _.Weight, opt => opt.MapFrom(i => i.Weight))
            .ForMember(_ => _.Size, opt => opt.MapFrom(i => i.Size));

            this.CreateMap<CharacteristicUpdateDTO, Characteristic>()
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Diameter, opt => opt.MapFrom(i => i.Diameter))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price))
            .ForMember(_ => _.Weight, opt => opt.MapFrom(i => i.Weight))
            .ForMember(_ => _.Size, opt => opt.MapFrom(i => i.Size));

            this.CreateMap<PizzaCreateDTO, Pizza>()
            .ForMember(_ => _.PizzaBaseID, opt => opt.MapFrom(i => i.PizzaBaseID));

            this.CreateMap<PizzaUpdateDTO, Pizza>()
            .ForMember(_ => _.PizzaBaseID, opt => opt.MapFrom(i => i.PizzaBaseID))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id));

            this.CreateMap<PizzaOrderCreateDTO, PizzaOrder>()
            .ForMember(_ => _.OrderId, opt => opt.MapFrom(i => i.OrderId))
            .ForMember(_ => _.PizzaID, opt => opt.MapFrom(i => i.PizzaID));


            this.CreateMap<PizzaOrderUpdateDTO, PizzaOrder>()
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.OrderId, opt => opt.MapFrom(i => i.OrderId))
            .ForMember(_ => _.PizzaID, opt => opt.MapFrom(i => i.PizzaID));

            this.CreateMap<OrderUpdateDTO, Order>()
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.ClientID, opt => opt.MapFrom(i => i.ClientID))
            .ForMember(_ => _.Date, opt => opt.MapFrom(i => i.Date))
            .ForMember(_ => _.PizzaOrders, opt => opt
            .MapFrom(i => i.PizzaOrders.Select(_ => new PizzaOrder { PizzaID = _ })));

            this.CreateMap<Order, OrderHistoryGetDTO>()
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.ClientID, opt => opt.MapFrom(i => i.ClientID))
            .ForMember(_ => _.Date, opt => opt.MapFrom(i => i.Date))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price));


            CreateMap<Account, AccountResponse>();

            CreateMap<Account, AuthenticateResponse>();

            CreateMap<RegisterRequest, Account>();

            CreateMap<CreateRequest, Account>();

            CreateMap<UpdateRequest, Account>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                    // ignore null & empty string properties
                    if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    // ignore null role
                    if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

                        return true;
                    }
                ));

        }

    }
}
