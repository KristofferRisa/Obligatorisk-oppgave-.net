namespace Trafikkal.web.Models
{
    public class SqlCommands
    {
        public string CalculateScore => @"select 
		cast(sum(answer1 + answer2) as decimal(18,0)) /*as CorrectAnswers*/ 
		/ sum(RightAnswerNotMultiple + RightAnswer1Multiple + RightAnswer2Multiple + RightAnswer3Multiple + RightAnswer4Multiple + RightAnswer5Multiple ) * 100 as PercentCorrect
from (

	select count(*) as Answer1,0 as Answer2
		,0 as RightAnswerNotMultiple, 0 as RightAnswer1Multiple, 0 as RightAnswer2Multiple, 0 as RightAnswer3Multiple, 0 as RightAnswer4Multiple, 0 RightAnswer5Multiple 
	 from Answers a 
	inner join Question q on a.QuestionNumber = q.Number and q.IsMultipleChoice = 0
	where ((a.Alternative = q.Alternative1 and q.IsAlternative1Correct = 1) /* finds every correct Alternative that is Alternative 1 */
	or (a.Alternative = q.Alternative2 and q.IsAlternative2Correct = 1)
	or (a.Alternative = q.Alternative3 and q.IsAlternative3Correct = 1)
	or (a.Alternative = q.Alternative4 and q.IsAlternative4Correct = 1)
	or (a.Alternative = q.Alternative5 and q.IsAlternative5Correct = 1))

	union

	select 
		0 as Answer1, count(*) as Answer2 
		,0 as RightAnswerNotMultiple, 0 as RightAnswer1Multiple, 0 as RightAnswer2Multiple, 0 as RightAnswer3Multiple, 0 as RightAnswer4Multiple, 0 RightAnswer5Multiple 
	from Answers a 
	inner join Question q on a.QuestionNumber = q.Number and q.IsMultipleChoice = 1
	where ((a.Alternative = q.Alternative1 and q.IsAlternative1Correct = 1) /* finds every correct Alternative that is Alternative 1 */
	or (a.Alternative = q.Alternative2 and q.IsAlternative2Correct = 1)
	or (a.Alternative = q.Alternative3 and q.IsAlternative3Correct = 1)
	or (a.Alternative = q.Alternative4 and q.IsAlternative4Correct = 1)
	or (a.Alternative = q.Alternative5 and q.IsAlternative5Correct = 1))

	union

	select 
		0 as Answer1
		,0 as Answer2
		,count(*) as RightAnswerNotMultiple
		,0 RightAnswer1Multiple 
		,0 RightAnswer2Multiple 
		,0 RightAnswer3Multiple 
		,0 RightAnswer4Multiple 
		,0 RightAnswer5Multiple 
	from Question where IsMultipleChoice = 0
	
	union
	
	select 
		0 as Answer1
		,0 as Answer2
		,0 as RightAnswerNotMultiple
		,count(*) as RightAnswer1Multiple 
		,0 RightAnswer2Multiple 
		,0 RightAnswer3Multiple 
		,0 RightAnswer4Multiple 
		,0 RightAnswer5Multiple 
	from Question 
	where IsMultipleChoice = 1 and IsAlternative1Correct=1

	union

	select 
		0 as Answer1
		,0 as Answer2
		,0 as RightAnswerNotMultiple
		,0 RightAnswer1Multiple 
		,count(*) RightAnswer2Multiple 
		,0 RightAnswer3Multiple 
		,0 RightAnswer4Multiple 
		,0 RightAnswer5Multiple 
	from Question 
	where IsMultipleChoice = 1 and IsAlternative2Correct=1
	
	union
	
	select 
		0 as Answer1
		,0 as Answer2
		,0 as RightAnswerNotMultiple
		,0 RightAnswer1Multiple 
		,0 RightAnswer2Multiple 
		,count(*) RightAnswer3Multiple 
		,0 RightAnswer4Multiple 
		,0 RightAnswer5Multiple 
	from Question 
	where IsMultipleChoice = 1 and IsAlternative3Correct=1
	
	union
	
	select 
		0 as Answer1
		,0 as Answer2
		,0 as RightAnswerNotMultiple
		,0 RightAnswer1Multiple 
		,0 RightAnswer2Multiple 
		,0 RightAnswer3Multiple 
		,count(*) RightAnswer4Multiple 
		,0 RightAnswer5Multiple 
	from Question 
	where IsMultipleChoice = 1 and IsAlternative4Correct=1
	
	union
	
	select 
		0 as Answer1
		,0 as Answer2
		,0 as RightAnswerNotMultiple
		,0 as RightAnswer1Multiple 
		,0 RightAnswer2Multiple 
		,0 RightAnswer3Multiple 
		,0 RightAnswer4Multiple 
		,count(*) RightAnswer5Multiple 
	from Question 
	where IsMultipleChoice = 1 and IsAlternative5Correct=1

) t";
    }
}
