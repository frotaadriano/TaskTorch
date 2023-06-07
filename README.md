#(ENGLISH)
# Study Plan - System.Threading.Tasks in .NET 7

## Introduction

In modern software development, asynchronous and parallel operations are essential for creating responsive and efficient applications. The `System.Threading.Tasks` namespace in the .NET Framework offers types that simplify the work with asynchronous and parallel tasks. This study plan will introduce the fundamental concepts related to `System.Threading.Tasks` and provide realistic examples to aid understanding.

## Relation with the Concept of Thread

Before delving into `System.Threading.Tasks`, it is helpful to understand the concept of threads. A thread is the smallest unit of processing that can be scheduled in an operating system. When we run multiple threads at the same time, we are executing parallel processes. This is essentially the basis for asynchronous and parallel programming. 

The `Task` class is an abstract representation of a job that needs to be executed. It encapsulates a unit of work that can be run asynchronously and in parallel, making thread management easier. `Tasks` can be seen as an evolution of threads, providing more features and better performance.

## Reference links
- Parallel programming in .NET: A guide to the documentation - https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/
- System.Threading.Tasks Namespace - https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks?view=net-7.0

## Study Topics

| Topic | Description | Example |
| --- | --- | --- |
| ConcurrentExclusiveSchedulerPair | Provides task schedulers that coordinate to execute tasks while ensuring that concurrent tasks may run concurrently and exclusive tasks never do. | Useful in scenarios where a group of tasks can run concurrently, but certain tasks need to be run exclusively without interruption. |
| Parallel | Provides support for parallel loops and regions. | You can use the Parallel class to execute loops (for, foreach) in parallel. |
| ParallelLoopState | Enables iterations of parallel loops to interact with other iterations. An instance of this class is provided by the Parallel class to each loop; you can not create instances in your code. | Useful when you need to break or skip iterations of a parallel loop. |
| ParallelOptions | Stores options that configure the operation of methods on the Parallel class. | Use to set the degree of parallelism in a parallel operation. |
| Task | Represents an asynchronous operation. | Use to execute an operation that doesn't return a value. |
| Task&lt;TResult&gt; | Represents an asynchronous operation that can return a value. | Use when you need an asynchronous operation to return a value. |
| TaskAsyncEnumerableExtensions | Provides a set of static methods for configuring task-related behaviors on asynchronous enumerables and disposables. | Use to apply cancellation or timeouts to an asynchronous IEnumerable. |
| TaskCanceledException | Represents an exception used to communicate task cancellation. | Generally caught in a catch block to handle task cancellations. |
| TaskCompletionSource | Represents the producer side of a Task unbound to a delegate, providing access to the consumer side through the Task property. | Use to create a task that you can manually control, including when it is considered complete. |
| TaskCompletionSource&lt;TResult&gt; | Represents the producer side of a Task&lt;TResult&gt; unbound to a delegate, providing access to the consumer side through the Task property. | Similar to TaskCompletionSource, but for tasks that return a value. |
| TaskExtensions | Provides a set of static methods for working with specific kinds of Task instances. | Provides helper methods for working with tasks, such as waiting for multiple tasks. |
| TaskFactory | Provides support for creating and scheduling Task objects. | Use to create and start tasks, as well as to chain multiple tasks together. |
| TaskFactory&lt;TResult&gt; | Provides support for creating and scheduling Task&lt;TResult&gt; objects. | Similar to TaskFactory, but for tasks that return a value. |
| TaskScheduler | Represents an object that handles the low-level work of queuing tasks onto threads. | Use to control how and when tasks are scheduled. |
| TaskSchedulerException | Represents an exception used to communicate an invalid operation by a TaskScheduler. | Generally caught in a catch block to handle errors when scheduling tasks. |
| UnobservedTaskExceptionEventArgs | Provides data for the event that is raised when the exception from a failed Task is not observed. | Use to handle exceptions from tasks that have not been observed or handled. |


#(PORTUGUESE)
# Plano de Estudos - System.Threading.Tasks em .NET 7

## Introdução

No desenvolvimento de software moderno, as operações assíncronas e paralelas são essenciais para criar aplicações responsivas e eficientes. O namespace `System.Threading.Tasks` no .NET Framework oferece tipos que simplificam o trabalho com tarefas paralelas e assíncronas. Este plano de estudos apresentará os conceitos fundamentais relacionados a `System.Threading.Tasks` e fornecerá exemplos realistas para auxiliar na compreensão.

## Relação com o Conceito de Thread

Antes de aprofundar o `System.Threading.Tasks`, é útil entender o conceito de threads. Uma thread é a menor unidade de processamento que pode ser programada em um sistema operacional. Quando executamos várias threads ao mesmo tempo, estamos executando processos paralelos. Isso é essencialmente a base para a programação assíncrona e paralela. 

A classe `Task` é uma representação abstrata de um trabalho que precisa ser executado. Ela encapsula uma unidade de trabalho que pode ser executada de forma assíncrona e paralela, tornando mais fácil o gerenciamento de threads. As `Tasks` podem ser vistas como uma evolução das threads, fornecendo mais recursos e melhor desempenho.


## Reference links
- Parallel programming in .NET: A guide to the documentation - https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/
- System.Threading.Tasks Namespace - https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks?view=net-7.0


## Tópicos do Estudo

| Tópico | Descrição | Exemplo |
| --- | --- | --- |
| ConcurrentExclusiveSchedulerPair | Provê agendadores de tarefas que coordenam para executar tarefas enquanto garantem que tarefas concorrentes podem rodar em paralelo e tarefas exclusivas nunca rodam em paralelo. | Útil em cenários onde um grupo de tarefas pode ser executado simultaneamente, mas algumas tarefas precisam ser executadas exclusivamente sem interrupção. |
| Parallel | Provê suporte para loops e regiões paralelas. | Você pode usar a classe Parallel para executar loops (for, foreach) em paralelo. |
| ParallelLoopState | Permite que iterações de loops paralelos interajam com outras iterações. Uma instância desta classe é fornecida pela classe Parallel para cada loop; você não pode criar instâncias no seu código. | Útil quando você precisa interromper ou saltar iterações de um loop paralelo. |
| ParallelOptions | Armazena opções que configuram a operação dos métodos na classe Parallel. | Use para definir o grau de paralelismo em uma operação paralela. |
| Task | Representa uma operação assíncrona. | Use para executar uma operação que não retorna um valor. |
| Task&lt;TResult&gt; | Representa uma operação assíncrona que pode retornar um valor. | Use quando precisa que uma operação assíncrona retorne um valor. |
| TaskAsyncEnumerableExtensions | Provê um conjunto de métodos estáticos para configurar comportamentos relacionados a tarefas em enumeráveis assíncronos e descartáveis. | Use para aplicar cancelamento ou timeouts em um IEnumerable assíncrono. |
| TaskCanceledException | Representa uma exceção usada para comunicar o cancelamento de uma tarefa. | Geralmente capturado em um bloco catch para lidar com o cancelamento de tarefas. |
| TaskCompletionSource | Representa o lado do produtor de uma tarefa não vinculada a um delegado, fornecendo acesso ao lado do consumidor através da propriedade Task. | Use para criar uma tarefa que você pode controlar manualmente, incluindo quando ela é considerada concluída. |
| TaskCompletionSource&lt;TResult&gt; | Representa o lado do produtor de uma tarefa&lt;TResult&gt; não vinculada a um delegado, fornecendo acesso ao lado do consumidor através da propriedade Task. | Semelhante ao TaskCompletionSource, mas para tarefas que retornam um valor. |
| TaskExtensions | Provê um conjunto de métodos estáticos para trabalhar com tipos específicos de instâncias de tarefa. | Fornece métodos auxiliares para trabalhar com tarefas, como esperar por várias tarefas. |
| TaskFactory | Provê suporte para criação e agendamento de objetos Task. | Use para criar e iniciar tarefas, bem como para encadear várias tarefas. |
| TaskFactory&lt;TResult&gt; | Provê suporte para criação e agendamento de objetos Task&lt;TResult&gt;. | Semelhante ao TaskFactory, mas para tarefas que retornam um valor. |
| TaskScheduler | Representa um objeto que lida com o trabalho de baixo nível de enfileirar tarefas em threads. | Use para controlar como e quando as tarefas são agendadas. |
| TaskSchedulerException | Representa uma exceção usada para comunicar uma operação inválida por um TaskScheduler. | Geralmente capturado em um bloco catch para lidar com erros ao agendar tarefas. |
| UnobservedTaskExceptionEventArgs | Provê dados para o evento que é levantado quando a exceção de uma tarefa falhada não é observada. | Use para lidar com exceções de tarefas que não foram observadas ou tratadas. |

