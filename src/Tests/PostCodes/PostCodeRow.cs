﻿using CountryData;

class PostCodeRow
{
    public string CountryCode;
    public string PostalCode;
    public string PlaceName; //nullable

    public string State; //nullable
    public string StateCode; //nullable

    public string Province; //nullable
    public string ProvinceCode; //nullable

    public string Community; //nullable
    public string CommunityCode; //nullable

    public Location Location;
    public ushort? Accuracy;
}