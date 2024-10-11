    using System;
    using DevExpress.Xpo;
    using DevExpress.Xpo.Metadata;
    using DevExpress.Data.Filtering;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
namespace CNPM_Community_support.Module.ORMDataModel1
{

    public partial class Bieumau
    {
        public Bieumau(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        //private byte[] image;
        //[ImageEditor]
        //public byte[] Image
        //{
        //    get => image;
        //    set => SetPropertyValue(nameof(Image), ref image, value);
        //}

        private MediaDataObject image;
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PopupPictureEdit,
            DetailViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorFixedHeight = 240, DetailViewImageEditorFixedWidth = 300,
            ListViewImageEditorCustomHeight = 40)]
        public MediaDataObject Image
        {
            get { return image; }
            set { SetPropertyValue(nameof(Image), ref image, value); }

        }



    }
}
