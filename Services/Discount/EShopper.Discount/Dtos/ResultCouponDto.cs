﻿namespace EShopper.Discount.Dtos
{
  public class ResultCouponDto
  {
    public int Id { get; set; }
    public string DiscountCode { get; set; }
    public int DiscountRate { get; set; }
    public DateTime ExpiresIn { get; set; }
    public bool IsActive { get; set; }
  }
}
