using CreateTest.Api.Dtos;

namespace CreateTest.Api.Services;

public interface IQuestionService
{
    public Task<Guid> CreateAsync(QuestionCreateDto questionCreateDto);
    public Task DeleteAsync (Guid questionId);
    public Task<QuestionGetDto> GetByIdAsync(Guid questionId);
    public Task UpdateAsync(Guid guid, QuestionCreateDto questionCreateDto);
    public Task<List<QuestionGetDto>> GetAllAsync();
    public Task<SolveReponseDto> SolveQuestionAsync(Guid questionId, string answer);
    public Task<QuestionGetDto> GetRandomQuestionAsync ();
    public Task<int> GetCountOfQuestionsAsync();



}