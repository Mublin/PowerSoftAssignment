﻿namespace PowersoftIntergration.Models;
public class CryptoCurrency
 {
    public string Id { get; set; }
    public string Rank { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public decimal? Supply { get; set; }
    public decimal? MaxSupply { get; set; }
    public decimal? MarketCapUsd { get; set; }
    public decimal? VolumeUsd24Hr { get; set; }
    public decimal? PriceUsd { get; set; }
    public decimal? ChangePercent24Hr { get; set; }
    public decimal? Vwap24Hr { get; set; }
}


