﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FixMi.Framework.Signals
{
    public class Signal
    {
        public struct SignalStatus
        {
            public const int NotApproved = 0;
            public const int Approved = 1;
            public const int Resolved = 2;            
        }

        public Signal() { }

        #region Public Properties

        public virtual string Name { get; set; }
        public virtual int SignalID { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Description { get; set; }
        public virtual bool ShowName { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string Email { get; set; }
        public virtual int Status { get; set; }
        public virtual DateTime ResolutionDate { get; set; }
        public virtual string ResolutionDescription { get; set; }
        public virtual decimal Latitude { get; set; }
        public virtual decimal Longitude { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Zip { get; set; }
        public virtual int Zoom { get; set; }
        public virtual string Attachment { get; set; }

        #endregion
    }

    public class SignalSubscription
    {
        public virtual int SignalID { get; set; }
        public virtual string Email { get; set; }
    }
}
