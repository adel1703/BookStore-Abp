using Acme.BookStore.Authors;
using BookStore.EntityFrameworkCore;
using BookStore;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Applications.Authors;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
{

}
