namespace JWT.APP.Back.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int AppRoleId { get; set; }

        public AppRole? AppRoles { get; set; }

        //public AppUser() // AppRole null olmaması için en kötüsü boş bir nesne örneği alırsın. Ama bu aynı anda role'e de new ile yeni kayıt atar
        //{
        //    AppRoles = new AppRole();
        //}
    }
}
