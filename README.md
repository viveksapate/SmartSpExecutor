Step 1: Include the package

![1737090582014](image/README/1737090582014.png)

Step 2: Register services

![1737357662691](image/README/1737357662691.png)

Step 3 : Here you go

![1737854550238](image/README/1737854550238.png)

Available Methods :

    /// <summary>
    /// Method executes the stored procedure and returns a rows modified count
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<long> ExecuteSpAsync(string storedProcName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Method executes the stored procedure and returns a rows modified count
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="procParameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<long> ExecuteSpAsync(string storedProcName, Dictionary<string, SqlParameter> procParameters, CancellationToken cancellationToken = default);

    /// <summary>
    /// Method executes the stored procedure and returns a dataset
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataSet> ExecuteSpReturnDataSetAsync(string storedProcName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Method executes the stored procedure and returns a dataset
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="procParameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataSet> ExecuteSpReturnDataSetAsync(string storedProcName, Dictionary<string, SqlParameter> procParameters, CancellationToken cancellationToken = default);

    /// <summary>
    /// Method executes the stored procedure and returns a same type which has been passed
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storedProcName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<T> ExecuteSpReturnTypeAsync<T>(string storedProcName, CancellationToken cancellationToken = default) where T : class, new();

    /// <summary>
    /// Method executes the stored procedure and returns a same type which has been passed
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storedProcName"></param>
    /// <param name="procParameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<T> ExecuteSpReturnTypeAsync<T>(string storedProcName, Dictionary<string, SqlParameter> procParameters, CancellationToken cancellationToken = default) where T : class, new();

    /// <summary>
    /// Method executes the stored procedure and returns a same list type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storedProcName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<T>> ExecuteSpReturnListTypeAsync<T>(string storedProcName, CancellationToken cancellationToken = default) where T : class, new();

    /// <summary>
    /// Method executes the stored procedure and returns a same list type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="storedProcName"></param>
    /// <param name="procParameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<T>> ExecuteSpReturnListTypeAsync<T>(string storedProcName, Dictionary<string, SqlParameter> procParameters, CancellationToken cancellationToken = default) where T : class, new();

    /// <summary>
    /// Method executes the stored procedure and returns a dataTable
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataTable> ExecuteSpReturnDataTableAsync(string storedProcName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Method executes the stored procedure and returns a dataTable
    /// </summary>
    /// <param name="storedProcName"></param>
    /// <param name="procParameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<DataTable> ExecuteSpReturnDataTableAsync(string storedProcName, Dictionary<string, SqlParameter> procParameters, CancellationToken cancellationToken = default);
