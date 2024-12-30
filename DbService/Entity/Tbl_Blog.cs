namespace DbService.Entity;

[Table("Tbl_Blog")]
public class Tbl_Blog
{
    [Key]
    public long BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set;}
    public string BlogContent { get; set;}
}
