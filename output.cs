public class COLUMNS {
 public string NAME { get; set; }
 public string VALUE { get; set; }

}
public class RECORDS {
 public string ID { get; set; }
 public IList<COLUMNS> COLUMNS { get; set; }

}
public class ADD_DATA {
 public IList<RECORDS> RECORDS { get; set; }

}
public class Application {
 public string REQUEST_ACTION { get; set; }
public ADD_DATA ADD_DATA { get; set; } 
 public int FORM_ID { get; set; }
 public int ORG_ID { get; set; }

}