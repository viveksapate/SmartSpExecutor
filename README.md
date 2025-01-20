Step 1: Include the package

![1737090582014](image/README/1737090582014.png)

Step 2: Register services

![1737357662691](image/README/1737357662691.png)

Step 3 : Here you go

![1737357628640](image/README/1737357628640.png)

Available Methods :

///`<summary>`

    /// Method executes the stored procedure and returns a rows modified count

    ///`</summary>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<long>` ExcuteSpAsync(stringstoredProcName, CancellationTokencancellationToken=default);

    ///`<summary>`

    /// Method executes the stored procedure and returns a rows modified count

    ///`</summary>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="procParameters">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<long>` ExcuteSpAsync(stringstoredProcName, Dictionary<string, SqlParameter> procParameters, CancellationTokencancellationToken=default);

    ///`<summary>`

    /// Method executes the stored procedure and returns a dataset

    ///`</summary>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<DataSet>` ExcuteSpReturnDataSetAsync(stringstoredProcName, CancellationTokencancellationToken=default);

    ///`<summary>`

    /// Method executes the stored procedure and returns a dataset

    ///`</summary>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="procParameters">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<DataSet>` ExcuteSpReturnDataSetAsync(stringstoredProcName, Dictionary<string, SqlParameter> procParameters, CancellationTokencancellationToken=default);

    ///`<summary>`

    /// Method executes the stored procedure and returns a same type which has been passed

    ///`</summary>`

    ///<typeparamname="T">`</typeparam>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<T>` ExecuteSpReturnTypeAsync `<T>`(stringstoredProcName, CancellationTokencancellationToken=default) whereT : class, new();

    ///`<summary>`

    /// Method executes the stored procedure and returns a same type which has been passed

    ///`</summary>`

    ///<typeparamname="T">`</typeparam>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="procParameters">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task`<T>` ExecuteSpReturnTypeAsync `<T>`(stringstoredProcName, Dictionary<string, SqlParameter> procParameters, CancellationTokencancellationToken=default) whereT : class, new();

    ///`<summary>`

    /// Method executes the stored procedure and returns a same list type

    ///`</summary>`

    ///<typeparamname="T">`</typeparam>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task<List`<T>`> ExecuteSpReturnListTypeAsync `<T>`(stringstoredProcName, CancellationTokencancellationToken=default) whereT : class, new();

    ///`<summary>`

    /// Method executes the stored procedure and returns a same list type

    ///`</summary>`

    ///<typeparamname="T">`</typeparam>`

    ///<paramname="storedProcName">`</param>`

    ///<paramname="procParameters">`</param>`

    ///<paramname="cancellationToken">`</param>`

    ///`<returns></returns>`

    Task<List`<T>`> ExecuteSpReturnListTypeAsync `<T>`(stringstoredProcName, Dictionary<string, SqlParameter> procParameters, CancellationTokencancellationToken=default) whereT : class, new();
