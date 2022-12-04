
using Moq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Test
{
    public class UserServiceTests
    {
        [Test]
        public void AddFriendMustNotAddNonExistentUsers()
        {
            var nonExistentUserAddingFriendData = new UserAddingFriendData();
            var userService = new UserService();

            Assert.Throws<UserNotFoundException>(() => { userService.AddFriend(nonExistentUserAddingFriendData); });
        }

        // Ниже - попытки собрать тест так, чтобы можно было запустить без IUserRepository
        // проблема остаётся в закрытом поле userRepository, к которому обращается тестируемый метод...

        //var nonExistentUserAddingFriendData = new UserAddingFriendData();
        //var mockUserRepository = new Mock<IUserRepository>();
        //var nonExistentUser = new UserEntity();
        //nonExistentUser = null;

        //    mockUserRepository.Setup(p => p.FindByEmail(nonExistentUserAddingFriendData.FriendEmail)).Returns(nonExistentUser);

        //var mockUserServise = new Mock<UserService>();
        ////mockUserServise.Setup
        //var us = new UserService();

        //var testUserServise = new UserService();

        //testUserServise.AddFriend(
    }
}