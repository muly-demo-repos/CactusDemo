import * as graphql from "@nestjs/graphql";
import { MYweirDcaPitaliZAtiOnService } from "../myweirdcapitalization/myweirdcapitalization.service";

export class MYweirDcaPitaliZAtiOnResolver {
  constructor(protected readonly service: MYweirDcaPitaliZAtiOnService) {}

  @graphql.Query(() => String)
  async MyCaPitalizedAcTion(
    @graphql.Args("args")
    args: string
  ): Promise<string> {
    return this.service.MyCaPitalizedAcTion(args);
  }
}
