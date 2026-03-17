using CreateTest.Api.Dtos;
using CreateTest.Api.Entities;
using CreateTest.Api.Mapper;
using CreateTest.Api.Repositories;

namespace CreateTest.Api.Services;

public class QuestionService : IQuestionService
{
    private readonly IRepository<Question> Repository;

    public QuestionService()
    {
        Repository = new Repository<Question>();
    }

    public async Task<Guid> CreateAsync(QuestionCreateDto questionCreateDto)
    {
        var question = questionCreateDto.ToEntity();
        question.QuestionId = Guid.NewGuid();
        var questions = await Repository.GetAllAsync();
        questions.Add(question);
        await Repository.SaveAllAsync(questions);
        return question.QuestionId;
    }

    public async Task DeleteAsync(Guid questionId)
    {
        var questions = await Repository.GetAllAsync();
        var count = questions.RemoveAll(q => q.QuestionId == questionId);
        if (count == 0)
        {
            throw new Exception($"Question with Id : {questionId} is not for deleting");
        }

        await Repository.SaveAllAsync(questions);
    }

    public async Task<List<QuestionGetDto>> GetAllAsync()
    {
        var questions = await Repository.GetAllAsync();
        var dtos = questions.Select(q => q.ToGetDto()).ToList();
        return dtos;
    }

    public async Task<QuestionGetDto> GetByIdAsync(Guid questionId)
    {
        var questions = await Repository.GetAllAsync();
        var question = questions.FirstOrDefault(q => q.QuestionId == questionId);

        if (question == null)
        {
            throw new Exception($"Question {questionId} has already exist");

        }
        return question.ToGetDto();
    }

    public async Task<int> GetCountOfQuestionsAsync()
    {
        var questions = await Repository.GetAllAsync();
        return questions.Count;
    }

    public async Task<QuestionGetDto> GetRandomQuestionAsync()
    {
        var questions = await Repository.GetAllAsync();
        var minIndex = 0;
        var maxIndex = questions.Count;

        var random = new Random();
        var index = random.Next(minIndex, maxIndex);

        return questions[index].ToGetDto();
    }

    public async Task<SolveReponseDto> SolveQuestionAsync(Guid questionId, string answer)
    {
        var question = await GetByIdAsync(questionId);

        if (question == null)
        {
            throw new Exception($"Question with Id : {questionId} is not for solving");

        }

        var res = question.Answer == answer;
        return new SolveReponseDto()
        {
            IsCorrect = res,
            CorrectAnswer = question.Answer,
        };


    }

    public async Task UpdateAsync(Guid guid, QuestionCreateDto questionCreateDto)
    {
        var questons = await Repository.GetAllAsync();
        foreach (var queston in questons)
        {
            if (queston.QuestionId == guid)
            {
                queston.Text = questionCreateDto.Text;
                queston.VariantA = questionCreateDto.VariantA;
                queston.VariantC = questionCreateDto.VariantC;
                queston.VariantB = questionCreateDto.VariantB;
                queston.Answer = questionCreateDto.Answer;
                break;
            }
        }

        await Repository.SaveAllAsync(questons);

    }
}
