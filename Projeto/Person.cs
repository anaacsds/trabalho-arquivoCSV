class Person
{
    public int Index { get; set; }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Sex { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string DateOfBirth { get; set; }
    public string JobTitle { get; set; }
    public Person(int index, string id, string firstname, string lastname, string sex, string email, string phone, string dateofbirth, string jobtitle)
    {
        Index = index;
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        Sex = sex;
        Email = email;
        Phone = phone;
        DateOfBirth = dateofbirth;
        JobTitle = jobtitle;
    }
}