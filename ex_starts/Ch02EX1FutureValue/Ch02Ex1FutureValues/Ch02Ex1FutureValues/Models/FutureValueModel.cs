namespace FutureValue.Models;
using System.ComponentModel.DataAnnotations;

public class FutureValueModel
{
    [Required(ErrorMessage ="Plaese enter a monthly investment amount")]
    [Range (1,2000)]
    public decimal? MonthlyInvestment { get; set; }
    [Required(ErrorMessage ="Plaese enter a valid interest rate")]
    [Range(.01,100, ErrorMessage = "Interest rate cannot be above 100%")]
    public decimal? YearlyInterestRate { get; set; }
    [Required(ErrorMessage ="Plaese enter a valid year")]
    [Range(1,100)]
    public int? Years { get; set; }

    public decimal? CalculateFutureValue()
    {
        int? months = Years * 12;
        decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
        decimal? futureValue = 0;
        for (int i = 0; i < months; i++)
        {
            futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
        }
        return futureValue;
    }
}
