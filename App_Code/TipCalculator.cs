using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TipCalculator
/// </summary>
public class TipCalculator
{

    private double amount;
    private double percent;
	public TipCalculator()
	{
		//
		// TODO: Add constructor logic here
		//
        Amount = 0;
        Percent = 0;
	}
    public TipCalculator(double amt, double perc)
    {
        //
        // TODO: Add 2nd constructor logic here
        //
        Amount = amt;
        Percent = perc;
    }
    public double Amount
    {
        set {amount = value; }
        get {return amount;}
    }
    public double Percent
    {
        set
        {
            if (value > 1)
            {
                value /= 100;
            }
            percent = value;
        }
        get
        {
            return percent;
        }
    }
    public double CalculateTip()
    {
        return Amount * Percent;
    }
    public double CalculateTotal()
    {
        return Amount + CalculateTip();
    }
}