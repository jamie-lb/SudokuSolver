using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace SudokuSolverCSharp
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private PuzzleSquare _square1 = new PuzzleSquare(1);
        private PuzzleSquare _square2 = new PuzzleSquare(2);
        private PuzzleSquare _square3 = new PuzzleSquare(3);
        private PuzzleSquare _square4 = new PuzzleSquare(4);
        private PuzzleSquare _square5 = new PuzzleSquare(5);
        private PuzzleSquare _square6 = new PuzzleSquare(6);
        private PuzzleSquare _square7 = new PuzzleSquare(7);
        private PuzzleSquare _square8 = new PuzzleSquare(8);
        private PuzzleSquare _square9 = new PuzzleSquare(9);
        private PuzzleSquare _square10 = new PuzzleSquare(10);
        private PuzzleSquare _square11 = new PuzzleSquare(11);
        private PuzzleSquare _square12 = new PuzzleSquare(12);
        private PuzzleSquare _square13 = new PuzzleSquare(13);
        private PuzzleSquare _square14 = new PuzzleSquare(14);
        private PuzzleSquare _square15 = new PuzzleSquare(15);
        private PuzzleSquare _square16 = new PuzzleSquare(16);
        private PuzzleSquare _square17 = new PuzzleSquare(17);
        private PuzzleSquare _square18 = new PuzzleSquare(18);
        private PuzzleSquare _square19 = new PuzzleSquare(19);
        private PuzzleSquare _square20 = new PuzzleSquare(20);
        private PuzzleSquare _square21 = new PuzzleSquare(21);
        private PuzzleSquare _square22 = new PuzzleSquare(22);
        private PuzzleSquare _square23 = new PuzzleSquare(23);
        private PuzzleSquare _square24 = new PuzzleSquare(24);
        private PuzzleSquare _square25 = new PuzzleSquare(25);
        private PuzzleSquare _square26 = new PuzzleSquare(26);
        private PuzzleSquare _square27 = new PuzzleSquare(27);
        private PuzzleSquare _square28 = new PuzzleSquare(28);
        private PuzzleSquare _square29 = new PuzzleSquare(29);
        private PuzzleSquare _square30 = new PuzzleSquare(30);
        private PuzzleSquare _square31 = new PuzzleSquare(31);
        private PuzzleSquare _square32 = new PuzzleSquare(32);
        private PuzzleSquare _square33 = new PuzzleSquare(33);
        private PuzzleSquare _square34 = new PuzzleSquare(34);
        private PuzzleSquare _square35 = new PuzzleSquare(35);
        private PuzzleSquare _square36 = new PuzzleSquare(36);
        private PuzzleSquare _square37 = new PuzzleSquare(37);
        private PuzzleSquare _square38 = new PuzzleSquare(38);
        private PuzzleSquare _square39 = new PuzzleSquare(39);
        private PuzzleSquare _square40 = new PuzzleSquare(40);
        private PuzzleSquare _square41 = new PuzzleSquare(41);
        private PuzzleSquare _square42 = new PuzzleSquare(42);
        private PuzzleSquare _square43 = new PuzzleSquare(43);
        private PuzzleSquare _square44 = new PuzzleSquare(44);
        private PuzzleSquare _square45 = new PuzzleSquare(45);
        private PuzzleSquare _square46 = new PuzzleSquare(46);
        private PuzzleSquare _square47 = new PuzzleSquare(47);
        private PuzzleSquare _square48 = new PuzzleSquare(48);
        private PuzzleSquare _square49 = new PuzzleSquare(49);
        private PuzzleSquare _square50 = new PuzzleSquare(50);
        private PuzzleSquare _square51 = new PuzzleSquare(51);
        private PuzzleSquare _square52 = new PuzzleSquare(52);
        private PuzzleSquare _square53 = new PuzzleSquare(53);
        private PuzzleSquare _square54 = new PuzzleSquare(54);
        private PuzzleSquare _square55 = new PuzzleSquare(55);
        private PuzzleSquare _square56 = new PuzzleSquare(56);
        private PuzzleSquare _square57 = new PuzzleSquare(57);
        private PuzzleSquare _square58 = new PuzzleSquare(58);
        private PuzzleSquare _square59 = new PuzzleSquare(59);
        private PuzzleSquare _square60 = new PuzzleSquare(60);
        private PuzzleSquare _square61 = new PuzzleSquare(61);
        private PuzzleSquare _square62 = new PuzzleSquare(62);
        private PuzzleSquare _square63 = new PuzzleSquare(63);
        private PuzzleSquare _square64 = new PuzzleSquare(64);
        private PuzzleSquare _square65 = new PuzzleSquare(65);
        private PuzzleSquare _square66 = new PuzzleSquare(66);
        private PuzzleSquare _square67 = new PuzzleSquare(67);
        private PuzzleSquare _square68 = new PuzzleSquare(68);
        private PuzzleSquare _square69 = new PuzzleSquare(69);
        private PuzzleSquare _square70 = new PuzzleSquare(70);
        private PuzzleSquare _square71 = new PuzzleSquare(71);
        private PuzzleSquare _square72 = new PuzzleSquare(72);
        private PuzzleSquare _square73 = new PuzzleSquare(73);
        private PuzzleSquare _square74 = new PuzzleSquare(74);
        private PuzzleSquare _square75 = new PuzzleSquare(75);
        private PuzzleSquare _square76 = new PuzzleSquare(76);
        private PuzzleSquare _square77 = new PuzzleSquare(77);
        private PuzzleSquare _square78 = new PuzzleSquare(78);
        private PuzzleSquare _square79 = new PuzzleSquare(79);
        private PuzzleSquare _square80 = new PuzzleSquare(80);
        private PuzzleSquare _square81 = new PuzzleSquare(81);
        private List<PuzzleSquare> _puzzleSquares = new List<PuzzleSquare>();
        private bool _canClear = true;
        private bool _canSolve = true;
        #endregion

        #region Public Variables
        private List<PuzzleSquare> puzzleSquares
        {
            get { return _puzzleSquares; }
            set
            {
                _puzzleSquares = value;
                OnPropertyChanged("puzzleSquares");
            }
        }

        private List<PuzzleSquare> knownSquares
        {
            get { return (from square in puzzleSquares where !square.KnownValue.Equals(0) select square).ToList(); }
        }

        private List<PuzzleSquare> trialKnownSquares
        {
            get
            {
                return (from square in unknownSquares where !square.TrialKnownValue.Equals(0) select square).ToList();
            }
        }

        private List<PuzzleSquare> unknownSquares
        {
            get { return (from square in this.puzzleSquares where square.KnownValue.Equals(0) select square).ToList(); }
        }

        private List<PuzzleSquare> trialUnknownSquares
        {
            get
            {
                return (from square in unknownSquares where square.TrialKnownValue.Equals(0) select square).ToList();
            }
        }

        public bool CanClear
        {
            get
            {
                return _canClear;
            }
            set
            {
                _canClear = value;
                OnPropertyChanged("CanClear");
            }
        }

        public bool CanSolve
        {
            get
            {
                return _canSolve;
            }
            set
            {
                _canSolve = value;
                OnPropertyChanged("CanSolve");
            }
        }

        public PuzzleSquare square1 { get { return _square1; } set { _square1 = value; } }
        public PuzzleSquare square2 { get { return _square2; } set { _square2 = value; } }
        public PuzzleSquare square3 { get { return _square3; } set { _square3 = value; } }
        public PuzzleSquare square4 { get { return _square4; } set { _square4 = value; } }
        public PuzzleSquare square5 { get { return _square5; } set { _square5 = value; } }
        public PuzzleSquare square6 { get { return _square6; } set { _square6 = value; } }
        public PuzzleSquare square7 { get { return _square7; } set { _square7 = value; } }
        public PuzzleSquare square8 { get { return _square8; } set { _square8 = value; } }
        public PuzzleSquare square9 { get { return _square9; } set { _square9 = value; } }
        public PuzzleSquare square10 { get { return _square10; } set { _square10 = value; } }
        public PuzzleSquare square11 { get { return _square11; } set { _square11 = value; } }
        public PuzzleSquare square12 { get { return _square12; } set { _square12 = value; } }
        public PuzzleSquare square13 { get { return _square13; } set { _square13 = value; } }
        public PuzzleSquare square14 { get { return _square14; } set { _square14 = value; } }
        public PuzzleSquare square15 { get { return _square15; } set { _square15 = value; } }
        public PuzzleSquare square16 { get { return _square16; } set { _square16 = value; } }
        public PuzzleSquare square17 { get { return _square17; } set { _square17 = value; } }
        public PuzzleSquare square18 { get { return _square18; } set { _square18 = value; } }
        public PuzzleSquare square19 { get { return _square19; } set { _square19 = value; } }
        public PuzzleSquare square20 { get { return _square20; } set { _square20 = value; } }
        public PuzzleSquare square21 { get { return _square21; } set { _square21 = value; } }
        public PuzzleSquare square22 { get { return _square22; } set { _square22 = value; } }
        public PuzzleSquare square23 { get { return _square23; } set { _square23 = value; } }
        public PuzzleSquare square24 { get { return _square24; } set { _square24 = value; } }
        public PuzzleSquare square25 { get { return _square25; } set { _square25 = value; } }
        public PuzzleSquare square26 { get { return _square26; } set { _square26 = value; } }
        public PuzzleSquare square27 { get { return _square27; } set { _square27 = value; } }
        public PuzzleSquare square28 { get { return _square28; } set { _square28 = value; } }
        public PuzzleSquare square29 { get { return _square29; } set { _square29 = value; } }
        public PuzzleSquare square30 { get { return _square30; } set { _square30 = value; } }
        public PuzzleSquare square31 { get { return _square31; } set { _square31 = value; } }
        public PuzzleSquare square32 { get { return _square32; } set { _square32 = value; } }
        public PuzzleSquare square33 { get { return _square33; } set { _square33 = value; } }
        public PuzzleSquare square34 { get { return _square34; } set { _square34 = value; } }
        public PuzzleSquare square35 { get { return _square35; } set { _square35 = value; } }
        public PuzzleSquare square36 { get { return _square36; } set { _square36 = value; } }
        public PuzzleSquare square37 { get { return _square37; } set { _square37 = value; } }
        public PuzzleSquare square38 { get { return _square38; } set { _square38 = value; } }
        public PuzzleSquare square39 { get { return _square39; } set { _square39 = value; } }
        public PuzzleSquare square40 { get { return _square40; } set { _square40 = value; } }
        public PuzzleSquare square41 { get { return _square41; } set { _square41 = value; } }
        public PuzzleSquare square42 { get { return _square42; } set { _square42 = value; } }
        public PuzzleSquare square43 { get { return _square43; } set { _square43 = value; } }
        public PuzzleSquare square44 { get { return _square44; } set { _square44 = value; } }
        public PuzzleSquare square45 { get { return _square45; } set { _square45 = value; } }
        public PuzzleSquare square46 { get { return _square46; } set { _square46 = value; } }
        public PuzzleSquare square47 { get { return _square47; } set { _square47 = value; } }
        public PuzzleSquare square48 { get { return _square48; } set { _square48 = value; } }
        public PuzzleSquare square49 { get { return _square49; } set { _square49 = value; } }
        public PuzzleSquare square50 { get { return _square50; } set { _square50 = value; } }
        public PuzzleSquare square51 { get { return _square51; } set { _square51 = value; } }
        public PuzzleSquare square52 { get { return _square52; } set { _square52 = value; } }
        public PuzzleSquare square53 { get { return _square53; } set { _square53 = value; } }
        public PuzzleSquare square54 { get { return _square54; } set { _square54 = value; } }
        public PuzzleSquare square55 { get { return _square55; } set { _square55 = value; } }
        public PuzzleSquare square56 { get { return _square56; } set { _square56 = value; } }
        public PuzzleSquare square57 { get { return _square57; } set { _square57 = value; } }
        public PuzzleSquare square58 { get { return _square58; } set { _square58 = value; } }
        public PuzzleSquare square59 { get { return _square59; } set { _square59 = value; } }
        public PuzzleSquare square60 { get { return _square60; } set { _square60 = value; } }
        public PuzzleSquare square61 { get { return _square61; } set { _square61 = value; } }
        public PuzzleSquare square62 { get { return _square62; } set { _square62 = value; } }
        public PuzzleSquare square63 { get { return _square63; } set { _square63 = value; } }
        public PuzzleSquare square64 { get { return _square64; } set { _square64 = value; } }
        public PuzzleSquare square65 { get { return _square65; } set { _square65 = value; } }
        public PuzzleSquare square66 { get { return _square66; } set { _square66 = value; } }
        public PuzzleSquare square67 { get { return _square67; } set { _square67 = value; } }
        public PuzzleSquare square68 { get { return _square68; } set { _square68 = value; } }
        public PuzzleSquare square69 { get { return _square69; } set { _square69 = value; } }
        public PuzzleSquare square70 { get { return _square70; } set { _square70 = value; } }
        public PuzzleSquare square71 { get { return _square71; } set { _square71 = value; } }
        public PuzzleSquare square72 { get { return _square72; } set { _square72 = value; } }
        public PuzzleSquare square73 { get { return _square73; } set { _square73 = value; } }
        public PuzzleSquare square74 { get { return _square74; } set { _square74 = value; } }
        public PuzzleSquare square75 { get { return _square75; } set { _square75 = value; } }
        public PuzzleSquare square76 { get { return _square76; } set { _square76 = value; } }
        public PuzzleSquare square77 { get { return _square77; } set { _square77 = value; } }
        public PuzzleSquare square78 { get { return _square78; } set { _square78 = value; } }
        public PuzzleSquare square79 { get { return _square79; } set { _square79 = value; } }
        public PuzzleSquare square80 { get { return _square80; } set { _square80 = value; } }
        public PuzzleSquare square81 { get { return _square81; } set { _square81 = value; } }
        #endregion

        #region Commands
        private RelayCommand clearGridCommand;
        public ICommand ClearGridCommand
        {
            get
            {
                if (this.clearGridCommand == null)
                {
                    this.clearGridCommand = new RelayCommand(this.ClearGrid, param => this.CanClear);
                }
                return this.clearGridCommand;
            }
        }

        private RelayCommand solvePuzzleCommand;
        public ICommand SolvePuzzleCommand
        {
            get
            {
                if (this.solvePuzzleCommand == null)
                {
                    this.solvePuzzleCommand = new RelayCommand(this.SolvePuzzle, param => this.CanSolve);
                }
                return this.solvePuzzleCommand;
            }
        }
        #endregion

        #region Private Functions
        private void ClearGrid(object param)
        {
            puzzleSquares.ForEach(square => square.EnteredValue = string.Empty);
        }

        private bool SolvableSquaresFound()
        {
            bool possibleValueFound = false;
            unknownSquares.ForEach(square =>
                {
                    if (GetSquarePossibleValues(square)) { possibleValueFound = true; }
                });
            return possibleValueFound;
        }

        private bool TrialSolvableSquaresFound()
        {
            bool valueFound = false;
            trialUnknownSquares.ForEach(square =>
                {
                    if (GetTrialSquarePossibleValues(square)) { valueFound = true; }
                });
            return valueFound;
        }

        private void RemoveSquarePossibleValue(PuzzleSquare source, Int32 value)
        {
            source.PossibleValues.Remove(value);
            if (source.PossibleValues.Count.Equals(1))
            {
                source.KnownValue = source.PossibleValues.FirstOrDefault();
                RemoveSquareConflictPossibleValues(source);
            }
        }

        private void RemoveTrialSquarePossibleValue(PuzzleSquare source, Int32 value)
        {
            source.TrialPossibleValues.Remove(value);
            if (source.TrialPossibleValues.Count.Equals(1))
            {
                source.TrialKnownValue = source.TrialPossibleValues.FirstOrDefault();
                RemoveTrialSquareConflictPossibleValues(source);
            }
        }

        private void RemoveSquareConflictPossibleValues(PuzzleSquare source)
        {
            if (source.KnownValue.Equals(0)) { return; }
            List<PuzzleSquare> conflicts = (from square in unknownSquares where !square.CellIndex.Equals(source.CellIndex) && (square.RowIndex.Equals(source.RowIndex) || square.ColumnIndex.Equals(source.ColumnIndex) || square.GroupIndex.Equals(source.GroupIndex)) select square).Distinct().ToList();
            conflicts.ForEach(square => RemoveSquarePossibleValue(square, source.KnownValue));
        }

        private void RemoveTrialSquareConflictPossibleValues(PuzzleSquare source)
        {
            if (source.TrialKnownValue.Equals(0)) { return; }
            List<PuzzleSquare> conflicts = (from square in trialUnknownSquares where !square.CellIndex.Equals(source.CellIndex) && (square.RowIndex.Equals(source.RowIndex) || square.ColumnIndex.Equals(source.ColumnIndex) || square.GroupIndex.Equals(source.GroupIndex)) select square).Distinct().ToList();
            conflicts.ForEach(square => RemoveTrialSquarePossibleValue(square, source.TrialKnownValue));
        }

        private bool GetTrialSquareUniquePossibleValues()
        {
            bool valueFound = false;
            List<PuzzleSquare> potentialTrialSolutions;
            List<PuzzleSquare> uniqueTrialSolutions;
            for (int i = 1; i <= 9; i++)
            {
                potentialTrialSolutions = (from square in trialUnknownSquares where square.TrialPossibleValues.Contains(i) select square).ToList();
                switch (potentialTrialSolutions.Count)
                {
                    case 0:
                        break;
                    case 1:
                        potentialTrialSolutions.FirstOrDefault().TrialKnownValue = i;
                        //trialUnknownSquares.ForEach(square => square.TrialPossibleValues = square.PossibleValues);
                        potentialTrialSolutions.ForEach(square => RemoveTrialSquareConflictPossibleValues(square));
                        valueFound = true;
                        break;
                    default:
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueTrialSolutions = (from square in potentialTrialSolutions where square.TrialPossibleValues.Contains(i) && square.RowIndex.Equals(j) select square).ToList();
                            if (uniqueTrialSolutions.Count.Equals(1))
                            {
                                uniqueTrialSolutions.FirstOrDefault().TrialKnownValue = i;
                                //trialUnknownSquares.ForEach(square => square.TrialPossibleValues = square.PossibleValues);
                                uniqueTrialSolutions.ForEach(square => RemoveTrialSquareConflictPossibleValues(square));
                                potentialTrialSolutions = (from square in trialUnknownSquares where square.TrialPossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueTrialSolutions = (from square in potentialTrialSolutions where square.TrialPossibleValues.Contains(i) && square.ColumnIndex.Equals(j) select square).ToList();
                            if (uniqueTrialSolutions.Count.Equals(1))
                            {
                                uniqueTrialSolutions.FirstOrDefault().TrialKnownValue = i;
                                //trialUnknownSquares.ForEach(square => square.TrialPossibleValues = square.PossibleValues);
                                uniqueTrialSolutions.ForEach(square => RemoveTrialSquareConflictPossibleValues(square));
                                potentialTrialSolutions = (from square in trialUnknownSquares where square.TrialPossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueTrialSolutions = (from square in potentialTrialSolutions where square.TrialPossibleValues.Contains(i) && square.GroupIndex.Equals(j) select square).ToList();
                            if (uniqueTrialSolutions.Count.Equals(1))
                            {
                                uniqueTrialSolutions.FirstOrDefault().TrialKnownValue = i;
                                //trialUnknownSquares.ForEach(square => square.TrialPossibleValues = square.PossibleValues);
                                uniqueTrialSolutions.ForEach(square => RemoveTrialSquareConflictPossibleValues(square));
                                potentialTrialSolutions = (from square in trialUnknownSquares where square.TrialPossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        break;
                }
            }
            return valueFound;
        }

        private bool GetSquareUniquePossibleValues()
        {
            bool valueFound = false;
            List<PuzzleSquare> potentialSolutions;
            List<PuzzleSquare> uniqueSolutions;
            for (int i = 1; i <= 9; i++)
            {
                potentialSolutions = (from square in unknownSquares where square.PossibleValues.Contains(i) select square).ToList();
                switch (potentialSolutions.Count)
                {
                    case 0:
                        break;
                    case 1:
                        potentialSolutions.FirstOrDefault().KnownValue = i;
                        potentialSolutions.ForEach(square => RemoveSquareConflictPossibleValues(square));
                        valueFound = true;
                        break;
                    default:
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueSolutions = (from square in potentialSolutions where square.PossibleValues.Contains(i) && square.RowIndex.Equals(j) select square).ToList();
                            if (uniqueSolutions.Count.Equals(1))
                            {
                                uniqueSolutions.FirstOrDefault().KnownValue = i;
                                uniqueSolutions.ForEach(square => RemoveSquareConflictPossibleValues(square));
                                potentialSolutions = (from square in unknownSquares where square.PossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueSolutions = (from square in potentialSolutions where square.PossibleValues.Contains(i) && square.ColumnIndex.Equals(j) select square).ToList();
                            if (uniqueSolutions.Count.Equals(1))
                            {
                                uniqueSolutions.FirstOrDefault().KnownValue = i;
                                uniqueSolutions.ForEach(square => RemoveSquareConflictPossibleValues(square));
                                potentialSolutions = (from square in unknownSquares where square.PossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        for (int j = 1; j <= 9; j++)
                        {
                            uniqueSolutions = (from square in potentialSolutions where square.PossibleValues.Contains(i) && square.GroupIndex.Equals(j) select square).ToList();
                            if (uniqueSolutions.Count.Equals(1))
                            {
                                uniqueSolutions.FirstOrDefault().KnownValue = i;
                                uniqueSolutions.ForEach(square => RemoveSquareConflictPossibleValues(square));
                                potentialSolutions = (from square in unknownSquares where square.PossibleValues.Contains(i) select square).ToList();
                                valueFound = true;
                            }
                        }
                        break;
                }
            }
            return valueFound;
        }

        private bool RemoveUniqueColumnGroupRowConflicts()
        {
            bool conflictsRemoved = false;
            List<Int32> columnUnknownValues = new List<Int32>();
            List<Int32> groupConflictIndices = new List<Int32>();
            List<Int32> rowConflictIndices = new List<Int32>();
            List<PuzzleSquare> columnUnknownSquares;
            List<PuzzleSquare> groupConflictSquares;
            List<PuzzleSquare> rowConflictSquares;
            for (int i = 1; i <= 9; i++)
            {
                columnUnknownValues = new List<Int32>();
                columnUnknownSquares = (from square in unknownSquares where square.ColumnIndex.Equals(i) select square).ToList();
                if (!columnUnknownSquares.Count.Equals(0))
                {
                    columnUnknownSquares.ForEach(square => columnUnknownValues.AddRange(square.PossibleValues));
                    columnUnknownValues = columnUnknownValues.Distinct().ToList();
                    columnUnknownValues.ForEach(value =>
                    {
                        groupConflictIndices = (from square in columnUnknownSquares where square.PossibleValues.Contains(value) select square.GroupIndex).Distinct().ToList();
                        if (groupConflictIndices.Count.Equals(1))
                        {
                            groupConflictSquares = (from square in unknownSquares where square.GroupIndex.Equals(groupConflictIndices.First()) && !square.ColumnIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                            if (!groupConflictSquares.Count.Equals(0))
                            {
                                groupConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                conflictsRemoved = true;
                            }
                        }
                        rowConflictIndices = (from square in columnUnknownSquares where square.PossibleValues.Contains(value) select square.RowIndex).Distinct().ToList();
                        if (rowConflictIndices.Count.Equals(1))
                        {
                            rowConflictSquares = (from square in unknownSquares where square.RowIndex.Equals(rowConflictIndices.First()) && !square.ColumnIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                            if (!rowConflictSquares.Count.Equals(0))
                            {
                                rowConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                conflictsRemoved = true;
                            }
                        }
                    });
                }
            }
            return conflictsRemoved;
        }

        private bool RemoveUniqueRowGroupColumnConflicts()
        {
            bool conflictsRemoved = false;
            List<Int32> rowUnknownValues = new List<Int32>();
            List<Int32> groupConflictIndices = new List<Int32>();
            List<Int32> columnConflictIndices = new List<Int32>();
            List<PuzzleSquare> rowUnknownSquares;
            List<PuzzleSquare> groupConflictSquares;
            List<PuzzleSquare> columnConflictSquares;
            for (int i = 1; i <= 9; i++)
            {
                rowUnknownValues = new List<Int32>();
                rowUnknownSquares = (from square in unknownSquares where square.RowIndex.Equals(i) select square).ToList();
                if (!rowUnknownSquares.Count.Equals(0))
                {
                    rowUnknownSquares.ForEach(square => rowUnknownValues.AddRange(square.PossibleValues));
                    rowUnknownValues = rowUnknownValues.Distinct().ToList();
                    rowUnknownValues.ForEach(value =>
                        {
                            groupConflictIndices = (from square in rowUnknownSquares where square.PossibleValues.Contains(value) select square.GroupIndex).Distinct().ToList();
                            if (groupConflictIndices.Count.Equals(1))
                            {
                                groupConflictSquares = (from square in unknownSquares where square.GroupIndex.Equals(groupConflictIndices.First()) && !square.RowIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                                if (!groupConflictSquares.Count.Equals(0))
                                {
                                    groupConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                    conflictsRemoved = true;
                                }
                            }
                            columnConflictIndices = (from square in rowUnknownSquares where square.PossibleValues.Contains(value) select square.ColumnIndex).Distinct().ToList();
                            if (columnConflictIndices.Count.Equals(1))
                            {
                                columnConflictSquares = (from square in unknownSquares where square.ColumnIndex.Equals(columnConflictIndices.First()) && !square.RowIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                                if (!columnConflictSquares.Count.Equals(0))
                                {
                                    columnConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                    conflictsRemoved = true;
                                }
                            }
                        });
                }
            }
            return conflictsRemoved;
        }

        private bool RemoveUniqueGroupRowColumnConflicts()
        {
            bool conflictsRemoved = false;
            List<Int32> groupUnknownValues = new List<Int32>();
            List<PuzzleSquare> groupUnknownSquares;
            List<Int32> columnConflictIndices = new List<Int32>();
            List<Int32> rowConflictIndices = new List<Int32>();
            List<PuzzleSquare> columnConflictSquares;
            List<PuzzleSquare> rowConflictSquares;
            for (int i = 1; i <= 9; i++)
            {
                groupUnknownValues = new List<Int32>();
                groupUnknownSquares = (from square in unknownSquares where square.GroupIndex.Equals(i) select square).ToList();
                if (!groupUnknownSquares.Count.Equals(0))
                {
                    groupUnknownSquares.ForEach(square => groupUnknownValues.AddRange(square.PossibleValues));
                    groupUnknownValues = groupUnknownValues.Distinct().ToList();
                    groupUnknownValues.ForEach(value =>
                        {
                            columnConflictIndices = (from square in groupUnknownSquares where square.PossibleValues.Contains(value) select square.ColumnIndex).Distinct().ToList();
                            if (columnConflictIndices.Count.Equals(1))
                            {
                                columnConflictSquares = (from square in unknownSquares where square.ColumnIndex.Equals(columnConflictIndices.First()) && !square.GroupIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                                if (!columnConflictSquares.Count.Equals(0))
                                {
                                    columnConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                    conflictsRemoved = true;
                                }
                            }
                            rowConflictIndices = (from square in groupUnknownSquares where square.PossibleValues.Contains(value) select square.RowIndex).Distinct().ToList();
                            if (rowConflictIndices.Count.Equals(1))
                            {
                                rowConflictSquares = (from square in unknownSquares where square.RowIndex.Equals(rowConflictIndices.First()) && !square.GroupIndex.Equals(i) && square.PossibleValues.Contains(value) select square).ToList();
                                if (!rowConflictSquares.Count.Equals(0))
                                {
                                    rowConflictSquares.ForEach(square => RemoveSquarePossibleValue(square, value));
                                    conflictsRemoved = true;
                                }
                            }
                        });
                }
            }
            return conflictsRemoved;
        }

        private bool GetTrialSquarePossibleValues(PuzzleSquare source)
        {
            List<Int32> conflictValues = (from square in trialKnownSquares where !square.CellIndex.Equals(source.CellIndex) && (square.RowIndex.Equals(source.RowIndex) || square.ColumnIndex.Equals(source.ColumnIndex) || square.GroupIndex.Equals(source.GroupIndex)) select square.TrialKnownValue).ToList();
            conflictValues.ForEach(value => source.TrialPossibleValues.Remove(value));
            if (source.TrialPossibleValues.Count.Equals(1))
            {
                source.TrialKnownValue = source.TrialPossibleValues.First();
                RemoveTrialSquareConflictPossibleValues(source);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool GetSquarePossibleValues(PuzzleSquare source)
        {
            //source.PossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<Int32> conflictValues = (from square in knownSquares where !square.CellIndex.Equals(source.CellIndex) && (square.RowIndex.Equals(source.RowIndex) || square.ColumnIndex.Equals(source.ColumnIndex) || square.GroupIndex.Equals(source.GroupIndex)) select square.KnownValue).ToList();
            conflictValues.ForEach(value => source.PossibleValues.Remove(value));
            if (source.PossibleValues.Count.Equals(1))
            {
                source.KnownValue = source.PossibleValues.FirstOrDefault();
                RemoveSquareConflictPossibleValues(source);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TrialDuplicatesExist()
        {
            List<PuzzleSquare> conflictSquares;
            foreach (PuzzleSquare square in trialKnownSquares)
            {
                conflictSquares = (from foundSquare in knownSquares where foundSquare.KnownValue.Equals(square.TrialKnownValue) && !foundSquare.CellIndex.Equals(square.CellIndex) && (square.RowIndex.Equals(foundSquare.RowIndex) || square.ColumnIndex.Equals(foundSquare.ColumnIndex) || square.GroupIndex.Equals(foundSquare.GroupIndex)) select foundSquare).Distinct().ToList();
                if (!conflictSquares.Count.Equals(0)) { return true; }
                conflictSquares = (from foundSquare in trialKnownSquares where foundSquare.TrialKnownValue.Equals(square.TrialKnownValue) && !foundSquare.CellIndex.Equals(square.CellIndex) && (square.RowIndex.Equals(foundSquare.RowIndex) || square.ColumnIndex.Equals(foundSquare.ColumnIndex) || square.GroupIndex.Equals(foundSquare.GroupIndex)) select foundSquare).Distinct().ToList();
                if (!conflictSquares.Count.Equals(0)) { return true; }
            }
            return false;
        }

        private bool SolutionFound()
        {
            bool continueLoop = false;
            while (!trialUnknownSquares.Count.Equals(0))
            {
                continueLoop = false;
                if (TrialSolvableSquaresFound()) { continueLoop = true; }
                if (!(from trialSquare in trialUnknownSquares where trialSquare.TrialPossibleValues.Count.Equals(0) select trialSquare).ToList().Count.Equals(0)) { return false; }
                if (TrialDuplicatesExist()) { return false; }
                if (GetTrialSquareUniquePossibleValues()) { continueLoop = true; }
                if (!(from trialSquare in trialUnknownSquares where trialSquare.TrialPossibleValues.Count.Equals(0) select trialSquare).ToList().Count.Equals(0)) { return false; }
                if (TrialDuplicatesExist()) { return false; }
                if (!continueLoop) { return false; }
            }
            if (trialUnknownSquares.Count.Equals(0)) { trialKnownSquares.ForEach(square => square.KnownValue = square.TrialKnownValue); }
            return true;
        }

        private bool GuessValues()
        {
            unknownSquares.ForEach(square => square.TrialPossibleValues = new List<Int32>(square.PossibleValues));
            foreach (PuzzleSquare square in unknownSquares)
            {
                foreach (Int32 value in square.TrialPossibleValues)
                {
                    square.TrialKnownValue = value;
                    if (SolutionFound()) { return true; }
                    ResetTrialValues(0);
                    unknownSquares.ForEach(trialSquare => trialSquare.TrialPossibleValues = new List<Int32>(trialSquare.PossibleValues));
                }
            }
            return false;
        }

        private void ResetTrialValues(Int32 index)
        {
            List<PuzzleSquare> trialSquares = (from square in trialKnownSquares where !square.CellIndex.Equals(index) select square).ToList();
            trialSquares.ForEach(square =>
                {
                    square.TrialKnownValue = 0;
                    square.TrialPossibleValues = new List<Int32>(square.PossibleValues);
                });
            trialUnknownSquares.ForEach(trialSquare => trialSquare.TrialPossibleValues = new List<Int32>(trialSquare.PossibleValues));
        }
        
        private void SolvePuzzle(object param)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            bool oneValueFound = false;
            this.CanClear = false;
            this.CanSolve = false;
            try
            {
                unknownSquares.ForEach(square => square.PossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                knownSquares.ForEach(square => RemoveSquareConflictPossibleValues(square));
                while (!unknownSquares.Count.Equals(0))
                {
                    oneValueFound = false;
                    if (SolvableSquaresFound()) { oneValueFound = true; }
                    if (!unknownSquares.Count.Equals(0) && this.GetSquareUniquePossibleValues()) { oneValueFound = true; }
                    if (!unknownSquares.Count.Equals(0) && this.RemoveUniqueGroupRowColumnConflicts()) { oneValueFound = true; }
                    if (!unknownSquares.Count.Equals(0) && this.RemoveUniqueRowGroupColumnConflicts()) { oneValueFound = true; }
                    if (!unknownSquares.Count.Equals(0) && this.RemoveUniqueColumnGroupRowConflicts()) { oneValueFound = true; }
                    if (!oneValueFound)
                    {
                        unknownSquares.ForEach(square => square.PossibleValues = new List<Int32> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                        knownSquares.ForEach(square => RemoveSquareConflictPossibleValues(square));
                        trialUnknownSquares.ForEach(trialSquare => trialSquare.TrialPossibleValues = new List<Int32>(trialSquare.PossibleValues));
                        if (!GuessValues()) { break; }
                    }
                }
            }
            finally
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                this.CanClear = true;
                this.CanSolve = true;
            }
        }
        #endregion

        #region INotifyPropertyChanged Events
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            this.puzzleSquares = new List<PuzzleSquare>();
            this.puzzleSquares.Add(square1);
            this.puzzleSquares.Add(square2);
            this.puzzleSquares.Add(square3);
            this.puzzleSquares.Add(square4);
            this.puzzleSquares.Add(square5);
            this.puzzleSquares.Add(square6);
            this.puzzleSquares.Add(square7);
            this.puzzleSquares.Add(square8);
            this.puzzleSquares.Add(square9);
            this.puzzleSquares.Add(square10);
            this.puzzleSquares.Add(square11);
            this.puzzleSquares.Add(square12);
            this.puzzleSquares.Add(square13);
            this.puzzleSquares.Add(square14);
            this.puzzleSquares.Add(square15);
            this.puzzleSquares.Add(square16);
            this.puzzleSquares.Add(square17);
            this.puzzleSquares.Add(square18);
            this.puzzleSquares.Add(square19);
            this.puzzleSquares.Add(square20);
            this.puzzleSquares.Add(square21);
            this.puzzleSquares.Add(square22);
            this.puzzleSquares.Add(square23);
            this.puzzleSquares.Add(square24);
            this.puzzleSquares.Add(square25);
            this.puzzleSquares.Add(square26);
            this.puzzleSquares.Add(square27);
            this.puzzleSquares.Add(square28);
            this.puzzleSquares.Add(square29);
            this.puzzleSquares.Add(square30);
            this.puzzleSquares.Add(square31);
            this.puzzleSquares.Add(square32);
            this.puzzleSquares.Add(square33);
            this.puzzleSquares.Add(square34);
            this.puzzleSquares.Add(square35);
            this.puzzleSquares.Add(square36);
            this.puzzleSquares.Add(square37);
            this.puzzleSquares.Add(square38);
            this.puzzleSquares.Add(square39);
            this.puzzleSquares.Add(square40);
            this.puzzleSquares.Add(square41);
            this.puzzleSquares.Add(square42);
            this.puzzleSquares.Add(square43);
            this.puzzleSquares.Add(square44);
            this.puzzleSquares.Add(square45);
            this.puzzleSquares.Add(square46);
            this.puzzleSquares.Add(square47);
            this.puzzleSquares.Add(square48);
            this.puzzleSquares.Add(square49);
            this.puzzleSquares.Add(square50);
            this.puzzleSquares.Add(square51);
            this.puzzleSquares.Add(square52);
            this.puzzleSquares.Add(square53);
            this.puzzleSquares.Add(square54);
            this.puzzleSquares.Add(square55);
            this.puzzleSquares.Add(square56);
            this.puzzleSquares.Add(square57);
            this.puzzleSquares.Add(square58);
            this.puzzleSquares.Add(square59);
            this.puzzleSquares.Add(square60);
            this.puzzleSquares.Add(square61);
            this.puzzleSquares.Add(square62);
            this.puzzleSquares.Add(square63);
            this.puzzleSquares.Add(square64);
            this.puzzleSquares.Add(square65);
            this.puzzleSquares.Add(square66);
            this.puzzleSquares.Add(square67);
            this.puzzleSquares.Add(square68);
            this.puzzleSquares.Add(square69);
            this.puzzleSquares.Add(square70);
            this.puzzleSquares.Add(square71);
            this.puzzleSquares.Add(square72);
            this.puzzleSquares.Add(square73);
            this.puzzleSquares.Add(square74);
            this.puzzleSquares.Add(square75);
            this.puzzleSquares.Add(square76);
            this.puzzleSquares.Add(square77);
            this.puzzleSquares.Add(square78);
            this.puzzleSquares.Add(square79);
            this.puzzleSquares.Add(square80);
            this.puzzleSquares.Add(square81);
        }
        #endregion
    }
}
