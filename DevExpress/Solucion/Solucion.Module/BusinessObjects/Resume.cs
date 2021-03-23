﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using MySolution.Module.BusinessObjects;

[DefaultClassOptions]
[ImageName("BO_Resume")]
public class Resume : BaseObject
{
    public Resume(Session session) : base(session) { }
    private Contact contact;
    public Contact Contact
    {
        get
        {
            return contact;
        }
        set
        {
            SetPropertyValue(nameof(Contact), ref contact, value);
        }
    }
    [Aggregated, Association("Resume-PortfolioFileData")]
    public XPCollection<PortfolioFileData> Portfolio
    {
        get { return GetCollection<PortfolioFileData>(nameof(Portfolio)); }
    }
}