using EShopper.Discount.Dtos;
using EShopper.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Discount.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CouponsController : ControllerBase
  {
    private readonly ICouponService _couponService;

    public CouponsController(ICouponService couponService)
    {
      _couponService = couponService;
    }

    [HttpGet]
    public IActionResult GetAllCoupons()
    {
      var coupons = _couponService.GetAllCoupons();
      return Ok(coupons);
    }

    [HttpGet("{id}")]
    public IActionResult GetCouponById(int id)
    {
      var coupon = _couponService.GetCouponById(id);
      return Ok(coupon);
    }

    [HttpPost]
    public IActionResult CreateCoupon(CreateCouponDto createCouponDto)
    {
      _couponService.CreateCoupon(createCouponDto);
      return Ok("Kupon Olusturuldu");
    }

    [HttpPut]
    public IActionResult UpdateCoupon(UpdateCouponDto updateCouponDto)
    {
      _couponService.UpdateCoupon(updateCouponDto);
      return Ok("Kupon Guncellendi");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCoupon(int id)
    {
      _couponService.DeleteCoupon(id);
      return Ok();
    }
  }
}
