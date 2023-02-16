// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp.SampleApp.Data
{
    public class DataGridDataItem : INotifyDataErrorInfo//, IComparable
    {
        private Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        private uint _rank;
        //private string _mountain;
        //private uint _height;
        //private string _range;
        //private string _parentMountain;
        private string _user;
        private string _rights;
        private bool _read;
        private bool _write;
        private bool _modify;
        private bool _none;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public uint Rank
        {
            get
            {
                return _rank;
            }

            set
            {
                if (_rank != value)
                {
                    _rank = value;
                }
            }
        }
        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                if (_user != value)
                {
                    _user = value;

                    bool isUserValid = !_errors.Keys.Contains("User");
                    if (_user == string.Empty && isUserValid)
                    {
                        List<string> errors = new List<string>();
                        errors.Add("User name cannot be empty");
                        _errors.Add("User", errors);
                        this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("User"));
                    }
                    else if (_user != string.Empty && !isUserValid)
                    {
                        _errors.Remove("User");
                        this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("User"));
                    }
                }
            }
        }
        //public string Admin="Admin";
        //public string ReadOnly="Readonly";
        //public string WriteOnly="Writeonly";
        //public string ModifyOnly="ModifyOnly";
        //public string None;
        //public string ReadWrite
        //{
        //    get { return "Read & Write"; }
        //}
        //public string ReadModfiy
        //{
        //    get { return "Read & Modify"; }
        //}
        //public string WriteModfiy
        //{
        //    get { return "Write & Modify"; }
        //}
        public string Rights
        {
            get
            {
                return _rights;
            }

            set
            {
                if (_rights != value)
                {
                    _rights = value;

                    bool isRightsValid = !_errors.Keys.Contains("Rights");
                    if (_rights == string.Empty && isRightsValid)
                    {
                        List<string> errors = new List<string>();
                        errors.Add("Rights name cannot be empty");
                        _errors.Add("Rights", errors);
                        this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Rights"));
                    }
                    else if (_rights != string.Empty && !isRightsValid)
                    {
                        _errors.Remove("Rights");
                        this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Rights"));
                    }
                }
            }
        }
        public bool Read
        {
            get
            {
                return _read;
            }

            set
            {
                if (_read != value)
                {
                    _read = value;
                }
            }
        }
        public bool Write
        {
            get
            {
                return _write;
            }

            set
            {
                if (_write != value)
                {
                    _write = value;
                }
            }
        }
        public bool Modify
        {
            get
            {
                return _modify;
            }

            set
            {
                if (_modify != value)
                {
                    _modify = value;
                }
            }
        }
        public bool None
        {
            get
            {
                return _none;
            }

            set
            {
                if (_none != value)
                {
                    _none = value;
                }
            }
        }
        //public string Mountain
        //{
        //    get
        //    {
        //        return _mountain;
        //    }

        //    set
        //    {
        //        if (_mountain != value)
        //        {
        //            _mountain = value;

        //            bool isMountainValid = !_errors.Keys.Contains("Mountain");
        //            if (_mountain == string.Empty && isMountainValid)
        //            {
        //                List<string> errors = new List<string>();
        //                errors.Add("Montain name cannot be empty");
        //                _errors.Add("Mountain", errors);
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Mountain"));
        //            }
        //            else if (_mountain != string.Empty && !isMountainValid)
        //            {
        //                _errors.Remove("Mountain");
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Mountain"));
        //            }
        //        }
        //    }
        //}

        //public uint Height_m
        //{
        //    get
        //    {
        //        return _height;
        //    }

        //    set
        //    {
        //        if (_height != value)
        //        {
        //            _height = value;
        //        }
        //    }
        //}

        //public string Range
        //{
        //    get
        //    {
        //        return _range;
        //    }

        //    set
        //    {
        //        if (_range != value)
        //        {
        //            _range = value;

        //            bool isRangeValid = !_errors.Keys.Contains("Range");
        //            if (_range == string.Empty && isRangeValid)
        //            {
        //                List<string> errors = new List<string>();
        //                errors.Add("Range name cannot be empty");
        //                _errors.Add("Range", errors);
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Range"));
        //            }
        //            else if (_range != string.Empty && !isRangeValid)
        //            {
        //                _errors.Remove("Range");
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Range"));
        //            }
        //        }
        //    }
        //}

        //public string Parent_mountain
        //{
        //    get
        //    {
        //        return _parentMountain;
        //    }

        //    set
        //    {
        //        if (_parentMountain != value)
        //        {
        //            _parentMountain = value;

        //            bool isParentValid = !_errors.Keys.Contains("Parent_mountain");
        //            if (_parentMountain == string.Empty && isParentValid)
        //            {
        //                List<string> errors = new List<string>();
        //                errors.Add("Parent_mountain name cannot be empty");
        //                _errors.Add("Parent_mountain", errors);
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Parent_mountain"));
        //            }
        //            else if (_parentMountain != string.Empty && !isParentValid)
        //            {
        //                _errors.Remove("Parent_mountain");
        //                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs("Parent_mountain"));
        //            }
        //        }
        //    }
        //}

        public string Coordinates { get; set; }

        public uint Prominence { get; set; }

        public uint First_ascent { get; set; }

        public string Ascents { get; set; }

        bool INotifyDataErrorInfo.HasErrors
        {
            get
            {
                return _errors.Keys.Count > 0;
            }
        }

        IEnumerable INotifyDataErrorInfo.GetErrors(string propertyName)
        {
            if (propertyName == null)
            {
                propertyName = string.Empty;
            }

            if (_errors.Keys.Contains(propertyName))
            {
                return _errors[propertyName];
            }
            else
            {
                return null;
            }
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    int lnCompare = Range.CompareTo((obj as DataGridDataItem).Range);

        //    if (lnCompare == 0)
        //    {
        //        return Parent_mountain.CompareTo((obj as DataGridDataItem).Parent_mountain);
        //    }
        //    else
        //    {
        //        return lnCompare;
        //    }
        //}
    }
}
