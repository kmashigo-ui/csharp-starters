// Completed Priority Queue Activity
// Scenario: an emergency room treats patients by urgency, not arrival order.
// PriorityQueue<TElement, TPriority> is a min-heap: smaller priority values come out first.

var waitingRoom = new PriorityQueue<Patient, int>();

waitingRoom.Enqueue(new Patient("Ava Chen", "sprained wrist"), 3);
waitingRoom.Enqueue(new Patient("Jordan Hale", "chest pain"), 1);
waitingRoom.Enqueue(new Patient("Sam Rivera", "fever"), 2);
waitingRoom.Enqueue(new Patient("Lee Ortiz", "paper cut"), 4);
waitingRoom.Enqueue(new Patient("Morgan Blake", "difficulty breathing"), 1);

Console.WriteLine($"Patients waiting: {waitingRoom.Count}");
Console.WriteLine($"Next to treat: {waitingRoom.Peek()}");
Console.WriteLine();
Console.WriteLine("Treatment order (lowest number = highest urgency):");

while (waitingRoom.TryDequeue(out var patient, out var urgency))
{
    Console.WriteLine($"  Urgency {urgency}: {patient}");
}

Console.WriteLine();
Console.WriteLine("Same patients, max-heap (highest score served first):");

var byScore = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
byScore.Enqueue("Lab results review", 40);
byScore.Enqueue("Stroke protocol", 100);
byScore.Enqueue("Follow-up call", 10);
byScore.Enqueue("Trauma bay", 95);

while (byScore.TryDequeue(out var task, out var score))
{
    Console.WriteLine($"  Score {score}: {task}");
}

sealed record Patient(string Name, string Complaint)
{
    public override string ToString() => $"{Name} ({Complaint})";
}
