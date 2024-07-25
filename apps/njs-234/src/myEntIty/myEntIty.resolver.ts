import * as graphql from "@nestjs/graphql";
import * as nestAccessControl from "nest-access-control";
import * as gqlACGuard from "../auth/gqlAC.guard";
import { GqlDefaultAuthGuard } from "../auth/gqlDefaultAuth.guard";
import * as common from "@nestjs/common";
import { MyEntItyResolverBase } from "./base/myEntIty.resolver.base";
import { MyEntIty } from "./base/MyEntIty";
import { MyEntItyService } from "./myEntIty.service";

@common.UseGuards(GqlDefaultAuthGuard, gqlACGuard.GqlACGuard)
@graphql.Resolver(() => MyEntIty)
export class MyEntItyResolver extends MyEntItyResolverBase {
  constructor(
    protected readonly service: MyEntItyService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
