﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.DotNet.Tools.Test;

internal interface IServer : INamedPipeBase, IAsyncDisposable
{
    PipeNameDescription PipeName { get; }

    Task WaitConnectionAsync(CancellationToken cancellationToken);
}
