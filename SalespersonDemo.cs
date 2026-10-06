using System;
using static System.Console;
using System.Globalization;
using System.Runtime.ExceptionServices;

public interface ISellable
{
	void SalesSpeech();
	void MakeSale(int inputValue);
}

public abstract class Salesperson: ISellable
{
	private string firstName;
	private string lastName;

	public abstract void SalesSpeech();
	public abstract void MakeSale(int inputValue);

	public Salesperson(string first, string last)
	{
		this.firstName = first;
		this.lastName = last;
	}

	public string FirstName
	{
		get {return firstName;}
		set {this.firstName = value;}
	}

	public string LastName
	{
		get {return lastName;}
		set {this.lastName = value;}
	}
 
	public string GetName()
	{
		return this.firstName + " " + this.lastName;
	}
}

public class RealEstateSalesperson: Salesperson
{
	private int totalValueSold = 0;
	private double totalCommissionEarned = 0.0;
	private double commissionRate;

	public RealEstateSalesperson(string first, string last, double rate) : base(first,last)
	{
		this.commissionRate = rate;
	}

	public override void SalesSpeech()
	{
		WriteLine("You would be a fool not to buy this house at this price!");
	}

	public override void MakeSale(int houseValue)
	{
		this.totalValueSold += houseValue;
		this.totalCommissionEarned = this.totalValueSold * this.commissionRate;
	}

	public int TotalValueSold
	{
		get {return this.totalValueSold;}
		set {this.totalValueSold = value;}
	}

	public double TotalCommissionEarned
	{
		get {return this.totalCommissionEarned;}
		set {this.totalCommissionEarned = value;}
	}

	public double CommissionRate
	{
		get {return this.commissionRate;}
		set {this.commissionRate = value;}
	}
}

public class GirlScout: Salesperson
{
	private int totalBoxes = 0;

	public GirlScout(string first, string last) : base(first, last) {}

	public override void SalesSpeech()
	{
		WriteLine("You would be a fool not to buy these cookies before they're gone!");
	}

	public override void MakeSale(int numBoxes)
	{
		this.totalBoxes += numBoxes;
	}

	public int TotalBoxes
	{
		get {return this.totalBoxes;}
		set {this.totalBoxes = value;}
	}
}

class SalespersonDemo
{
	static void Main()
	{
		// Write your code here
		RealEstateSalesperson houseSeller = new RealEstateSalesperson("Charlie", "Nally", 0.05);
		GirlScout scout = new GirlScout("Millie", "Nally");

		houseSeller.SalesSpeech();
		houseSeller.MakeSale(100000);
		houseSeller.MakeSale(140000);

		WriteLine($"{houseSeller.GetName()} Total Value Sold: {houseSeller.TotalValueSold.ToString("C", CultureInfo.GetCultureInfo("en-US"))} Total Commission Earned: {houseSeller.TotalCommissionEarned.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");

		scout.SalesSpeech();
		scout.MakeSale(10);
		scout.MakeSale(24);
		scout.MakeSale(111);

		WriteLine($"{scout.GetName()} Total Boxes Sold: {scout.TotalBoxes}");
	}
}
