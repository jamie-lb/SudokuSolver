using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SudokuSolverCSharp
{
    class PuzzleSquare : INotifyPropertyChanged
    {
        #region Private Variables
        private List<Int32> _possibleValues = new List<Int32>();
        private List<Int32> _trialPossibleValues = new List<Int32>();
        private string _enteredValue = String.Empty;
        private Int32 _knownValue = 0;
        private Int32 _trialKnownValue = 0;
        private Int32 _cellIndex = 0;
        private Int32 _rowIndex = 0;
        private Int32 _columnIndex = 0;
        private Int32 _groupIndex = 0;
        #endregion

        #region Public Properties
        public List<Int32> PossibleValues
        {
            get { return this._possibleValues; }
            set
            {
                this._possibleValues = value;
                OnPropertyChanged("PossibleValues");
                //if (value.Count.Equals(1)) { this.KnownValue = value.FirstOrDefault(); }
            }
        }
        public List<Int32> TrialPossibleValues
        {
            get
            {
                return this._trialPossibleValues;
            }
            set
            {
                this._trialPossibleValues = value;
                OnPropertyChanged("TrialPossibleValues");
            }
        }
        public string EnteredValue
        {
            get { return this._enteredValue; }
            set
            {
                Int32 newKnownValue;
                this._enteredValue = value;
                if (Int32.TryParse(value, out newKnownValue))
                {
                    if (newKnownValue != this.KnownValue)
                    {
                        this.KnownValue = newKnownValue;
                    }
                }
                else
                {
                    if (this.KnownValue != 0)
                    {
                        this.KnownValue = 0;
                    }
                }
                OnPropertyChanged("EnteredValue");
            }
        }
        public Int32 TrialKnownValue
        {
            get
            {
                return _trialKnownValue;
            }
            set
            {
                _trialKnownValue = value;
                if (value == 0)
                {
                    this.TrialPossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
                else
                {
                    this.TrialPossibleValues = new List<Int32>();
                }
            }
        }
        public Int32 KnownValue
        {
            get { return _knownValue; }
            set
            {
                _knownValue = value;
                this.TrialKnownValue = value;
                if (value == 0)
                {
                    this.PossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    if (this.EnteredValue.Trim().Length != 0)
                    {
                        this.EnteredValue = String.Empty;
                    }
                }
                else
                {
                    this.PossibleValues = new List<Int32>();
                    if (this.EnteredValue != value.ToString())
                    {
                        this.EnteredValue = value.ToString();
                    }
                }
                OnPropertyChanged("KnownValue");
            }
        }
        public Int32 RowIndex
        {
            get { return this._rowIndex; }
        }
        public Int32 ColumnIndex
        {
            get { return this._columnIndex; }
        }
        public Int32 GroupIndex
        {
            get { return this._groupIndex; }
        }
        public Int32 CellIndex
        {
            get { return this._cellIndex; }
            set
            {
                this._cellIndex = value;
                OnPropertyChanged("CellIndex");
            }
        }
        #endregion

        #region Constructors
        public PuzzleSquare(Int32 cellIdx)
        {
            this.PossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.TrialPossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.CellIndex = cellIdx;
            this._rowIndex = GetRowIndex();
            this._columnIndex = GetColumnIndex();
            this._groupIndex = GetGroupIndex();
        }
        #endregion

        #region Private Methods
        private Int32 GetRowIndex()
        {
            switch (this.CellIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return 1;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    return 2;
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                    return 3;
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                    return 4;
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                    return 5;
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                    return 6;
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                case 63:
                    return 7;
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                    return 8;
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                case 80:
                case 81:
                    return 9;
                default:
                    return 0;
            }
        }

        private Int32 GetColumnIndex()
        {
            switch (this.CellIndex)
            {
                case 1:
                case 10:
                case 19:
                case 28:
                case 37:
                case 46:
                case 55:
                case 64:
                case 73:
                    return 1;
                case 2:
                case 11:
                case 20:
                case 29:
                case 38:
                case 47:
                case 56:
                case 65:
                case 74:
                    return 2;
                case 3:
                case 12:
                case 21:
                case 30:
                case 39:
                case 48:
                case 57:
                case 66:
                case 75:
                    return 3;
                case 4:
                case 13:
                case 22:
                case 31:
                case 40:
                case 49:
                case 58:
                case 67:
                case 76:
                    return 4;
                case 5:
                case 14:
                case 23:
                case 32:
                case 41:
                case 50:
                case 59:
                case 68:
                case 77:
                    return 5;
                case 6:
                case 15:
                case 24:
                case 33:
                case 42:
                case 51:
                case 60:
                case 69:
                case 78:
                    return 6;
                case 7:
                case 16:
                case 25:
                case 34:
                case 43:
                case 52:
                case 61:
                case 70:
                case 79:
                    return 7;
                case 8:
                case 17:
                case 26:
                case 35:
                case 44:
                case 53:
                case 62:
                case 71:
                case 80:
                    return 8;
                case 9:
                case 18:
                case 27:
                case 36:
                case 45:
                case 54:
                case 63:
                case 72:
                case 81:
                    return 9;
                default:
                    return 0;
            }
        }

        private Int32 GetGroupIndex()
        {
            switch (this.CellIndex)
            {
                case 1:
                case 2:
                case 3:
                case 10:
                case 11:
                case 12:
                case 19:
                case 20:
                case 21:
                    return 1;
                case 4:
                case 5:
                case 6:
                case 13:
                case 14:
                case 15:
                case 22:
                case 23:
                case 24:
                    return 2;
                case 7:
                case 8:
                case 9:
                case 16:
                case 17:
                case 18:
                case 25:
                case 26:
                case 27:
                    return 3;
                case 28:
                case 29:
                case 30:
                case 37:
                case 38:
                case 39:
                case 46:
                case 47:
                case 48:
                    return 4;
                case 31:
                case 32:
                case 33:
                case 40:
                case 41:
                case 42:
                case 49:
                case 50:
                case 51:
                    return 5;
                case 34:
                case 35:
                case 36:
                case 43:
                case 44:
                case 45:
                case 52:
                case 53:
                case 54:
                    return 6;
                case 55:
                case 56:
                case 57:
                case 64:
                case 65:
                case 66:
                case 73:
                case 74:
                case 75:
                    return 7;
                case 58:
                case 59:
                case 60:
                case 67:
                case 68:
                case 69:
                case 76:
                case 77:
                case 78:
                    return 8;
                case 61:
                case 62:
                case 63:
                case 70:
                case 71:
                case 72:
                case 79:
                case 80:
                case 81:
                    return 9;
                default:
                    return 0;
            }
        }
        #endregion

        #region INotifyPropertyChanged Events
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
