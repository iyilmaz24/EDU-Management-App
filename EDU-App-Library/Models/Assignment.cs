namespace EDU_App_Library.Models{

    public class Assignment {
        public Assignment() {
            
        }

        private string? _name;
        public string? Name {
            get { return _name ?? "";}
            set { _name = value; }
        }
    
        private string? _description;
        public string? Description {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        
        private double? _totalAvailablePoints;
        public double? TotalAvailablePoints {
            get { return _totalAvailablePoints ?? 0.0; }
            set { _totalAvailablePoints = value; }
        }
        
        private string? _dueDate;
        public string? DueDate {
            get { return _dueDate ?? ""; }
            set { _dueDate = value; }
        }
        public override string ToString()
        {
            return $"{Name} - {Description}";
        }

    }

}