import * as graphql from "@nestjs/graphql";
import { MOduleWithWeirDddNaMeService } from "../modulewithweirdddname/modulewithweirdddname.service";

export class MOduleWithWeirDddNaMeResolver {
  constructor(protected readonly service: MOduleWithWeirDddNaMeService) {}

  @graphql.Query(() => String)
  async WeiRdaCTion(
    @graphql.Args("args")
    args: string
  ): Promise<string> {
    return this.service.WeiRdaCTion(args);
  }
}
