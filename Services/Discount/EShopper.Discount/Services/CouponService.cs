using EShopper.Discount.Context;
using EShopper.Discount.Dtos;
using EShopper.Discount.Entities;

namespace EShopper.Discount.Services
{
  public class CouponService : ICouponService
  {
    private readonly DiscountContext context;

    public CouponService(DiscountContext discountContext)
    {
      context = discountContext;
    }

    public void CreateCoupon(CreateCouponDto createCouponDto)
    {
      var coupon = new Coupon
      {
        DiscountCode = createCouponDto.DiscountCode,
        DiscountRate = createCouponDto.DiscountRate,
        ExpiresIn = createCouponDto.ExpiresIn,
        IsActive = createCouponDto.IsActive
      };

      context.Add(coupon);
      context.SaveChanges();
    }

    public void DeleteCoupon(int id)
    {
      var value = context.Coupons.Find(id);
      context.Coupons.Remove(value);
      context.SaveChanges();
    }

    public List<ResultCouponDto> GetAllCoupons()
    {
      var values = context.Coupons.ToList();
      return (from x in values
              select new ResultCouponDto
              {
                Id = x.Id,
                DiscountCode = x.DiscountCode,
                DiscountRate = x.DiscountRate,
                ExpiresIn = x.ExpiresIn,
                IsActive = x.IsActive
              }).ToList();
    }

    public GetCouponByIdDto GetCouponById(int id)
    {
      var value = context.Coupons.Find(id);
      return new GetCouponByIdDto
      {
        Id = value.Id,
        DiscountCode = value.DiscountCode,
        DiscountRate = value.DiscountRate,
        ExpiresIn = value.ExpiresIn,
        IsActive = value.IsActive
      };
    }

    public void UpdateCoupon(UpdateCouponDto updateCouponDto)
    {
      var coupon = new Coupon
      {
        Id = updateCouponDto.Id,
        DiscountCode = updateCouponDto.DiscountCode,
        DiscountRate = updateCouponDto.DiscountRate,
        ExpiresIn = updateCouponDto.ExpiresIn,
        IsActive = updateCouponDto.IsActive
      };
      context.Coupons.Add(coupon);
      context.SaveChanges(); 
    }
  }
}
