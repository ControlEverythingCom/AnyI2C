
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AnyI2C
{
    class NumLabel : Label
    {
        string mPrefix = string.Empty;

        public string Prefix
        {
            get { return mPrefix; }
            set 
            { 
                mPrefix = value;
                UpdateText();

            }
        }

        public enum ViewFormat
        {
            Hex,
            Decimal
        }
        private ViewFormat mFormat = ViewFormat.Hex;

        internal ViewFormat Format
        {
            get { return mFormat; }
            set 
            { 
                mFormat = value;
                UpdateText();
            }
        }

        private int[] mValue = new int[]{0};

        public int [] Value
        {
            get 
            { 
                return mValue; 
            }
            set 
            { 
                mValue = new int[value.Length];
                Array.Copy(value, mValue, value.Length);
                UpdateText();
            }
        }

        private void UpdateText()
        {
            string str = string.Empty;
            if (mFormat == ViewFormat.Decimal)
            {
                str = string.Format("{0} ", mPrefix);
            }
            else if (mFormat == ViewFormat.Hex)
            {
                str = string.Format("{0} ", mPrefix);
            }

            for (int i = 0; i < mValue.Length; i++)
            {
                if (mFormat == ViewFormat.Decimal)
                {
                    str += string.Format("{0:D} ", mValue[i]);
                }
                else if (mFormat == ViewFormat.Hex)
                {
                    str += string.Format("0x{0:X} ", mValue[i]);
                }
            }
            if (mFormat == ViewFormat.Decimal)
            {
                str += "[Dec]";
            }
            else if (mFormat == ViewFormat.Hex)
            {
                str += "[Hex]";
            }
            Text = str;
        }

        private bool mIsShowText = false;

        public bool IsShowText
        {
            get { return mIsShowText; }
            set { mIsShowText = value; }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BorderStyle = BorderStyle.None;
            base.OnMouseLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            if (mFormat == ViewFormat.Hex)
            {
                mFormat = ViewFormat.Decimal;
            }
            else if (mFormat == ViewFormat.Decimal)
            {
                mFormat = ViewFormat.Hex;
            }
            UpdateText();
            Invalidate();
            base.OnClick(e);
        }

    }
}
