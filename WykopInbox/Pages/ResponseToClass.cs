namespace WykopInbox.Pages
{
    
    public class Actions
    {
        public bool? vote_up { get; set; }
        public bool? vote_down { get; set; }
        public bool? create { get; set; }
        public bool? delete { get; set; }
        public bool? update { get; set; }
        public bool? report { get; set; }
        public bool? create_favourite { get; set; }
        public bool? delete_favourite { get; set; }
        public bool? undo_vote { get; set; }
        public bool? pin { get; set; }
        public bool? unpin { get; set; }
    }

    public class Author
    {
        public string username { get; set; }
        public string gender { get; set; }
        public bool? company { get; set; }
        public string avatar { get; set; }
        public string status { get; set; }
        public string color { get; set; }
        public bool? verified { get; set; }
        public Rank rank { get; set; }
        public bool? blacklist { get; set; }
        public bool? follow { get; set; }
        public bool? note { get; set; }
        public bool? online { get; set; }
    }

    public class Comments
    {
        public List<Item> items { get; set; }
        public int? count { get; set; }
    }

    public class Datum
    {
        public int? id { get; set; }
        public string slug { get; set; }
        public Author author { get; set; }
        public string device { get; set; }
        public string created_at { get; set; }
        public int? voted { get; set; }
        public string content { get; set; }
        public Media media { get; set; }
        public bool? adult { get; set; }
        public List<string> tags { get; set; }
        public bool? favourite { get; set; }
        public object parent { get; set; }
        public Votes votes { get; set; }
        public bool? editable { get; set; }
        public bool? deletable { get; set; }
        public Comments comments { get; set; }
        public string resource { get; set; }
        public Actions actions { get; set; }
        public bool? archive { get; set; }
        public bool? observed_discussion { get; set; }
        public string status { get; set; }
        public bool? tag_pinned_content { get; set; }
        public bool? pinnable { get; set; }
    }

    public class Embed
    {
        public string key { get; set; }
        public string type { get; set; }
        public string thumbnail { get; set; }
        public string url { get; set; }
        public string age_category { get; set; }
        public object video_metadata { get; set; }
        public bool? commercial { get; set; }
    }

    public class Item
    {
        public int? id { get; set; }
        public string slug { get; set; }
        public Author author { get; set; }
        public string device { get; set; }
        public string created_at { get; set; }
        public int? voted { get; set; }
        public string content { get; set; }
        public Media media { get; set; }
        public bool? adult { get; set; }
        public List<object> tags { get; set; }
        public bool? favourite { get; set; }
        public Parent parent { get; set; }
        public Votes votes { get; set; }
        public bool? editable { get; set; }
        public bool? deletable { get; set; }
        public bool? blacklist { get; set; }
        public object deleted { get; set; }
        public string resource { get; set; }
        public Actions actions { get; set; }
        public bool? archive { get; set; }
    }

    public class Location
    {
        public string filter { get; set; }
        public int? page { get; set; }
    }

    public class Media
    {
        public Photo photo { get; set; }
        public Embed embed { get; set; }
        public object survey { get; set; }
    }

    public class Pagination
    {
        public int? per_page { get; set; }
        public int? total { get; set; }
    }

    public class Parent
    {
        public string resource { get; set; }
        public int? id { get; set; }
        public string slug { get; set; }
        public Author author { get; set; }
        public List<Location> location { get; set; }
    }

    public class Photo
    {
        public string key { get; set; }
        public string label { get; set; }
        public string mime_type { get; set; }
        public string url { get; set; }
        public int? size { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
    }

    public class Rank
    {
        public int? position { get; set; }
        public int? trend { get; set; }
    }

    public class Root
    {

        public List<Datum> data { get; set; }
        public Pagination pagination { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string gender { get; set; }
        public bool? company { get; set; }
        public string avatar { get; set; }
        public string status { get; set; }
        public string color { get; set; }
        public bool? verified { get; set; }
        public Rank rank { get; set; }
        public bool? blacklist { get; set; }
        public bool? follow { get; set; }
        public bool? note { get; set; }
        public bool? online { get; set; }
    }

    public class Votes
    {
        public int? up { get; set; }
        public int? down { get; set; }
        public List<User> users { get; set; }
    }


}
