﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CNPM_Community_support.Module.ORMDataModel1
{

    public partial class Quyengop : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fNoidung;
        [Size(SizeAttribute.Unlimited)]
        public string Noidung
        {
            get { return fNoidung; }
            set { SetPropertyValue<string>(nameof(Noidung), ref fNoidung, value); }
        }
        DateTime fThoigian;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Thoigian
        {
            get { return fThoigian; }
            set { SetPropertyValue<DateTime>(nameof(Thoigian), ref fThoigian, value); }
        }
        decimal fSotienquyengop;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")]
        public decimal Sotienquyengop
        {
            get { return fSotienquyengop; }
            set { SetPropertyValue<decimal>(nameof(Sotienquyengop), ref fSotienquyengop, value); }
        }
        string fAnhminhchung;
        public string Anhminhchung
        {
            get { return fAnhminhchung; }
            set { SetPropertyValue<string>(nameof(Anhminhchung), ref fAnhminhchung, value); }
        }
        User fUserID;
        public User UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<User>(nameof(UserID), ref fUserID, value); }
        }
        Bieumau fBieumauID;
        [Association(@"QuyengopReferencesBieumau")]
        public Bieumau BieumauID
        {
            get { return fBieumauID; }
            set { SetPropertyValue<Bieumau>(nameof(BieumauID), ref fBieumauID, value); }
        }
    }

}
