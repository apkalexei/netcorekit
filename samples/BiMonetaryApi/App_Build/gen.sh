~/.nuget/packages/grpc.tools/1.17.1/tools/linux_x64/protoc -I ./../../protos/v1 --csharp_out ./../Rpc --grpc_out ./../Rpc ./../../protos/v1/bimonetary.proto --plugin=protoc-gen-grpc=${HOME}/.nuget/packages/grpc.tools/1.17.1/tools/linux_x64/grpc_csharp_plugin