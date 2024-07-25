/*
------------------------------------------------------------------------------ 
This code was generated by Amplication. 
 
Changes to this file will be lost if the code is regenerated. 

There are other ways to to customize your code, see this doc to learn more
https://docs.amplication.com/how-to/custom-code

------------------------------------------------------------------------------
  */
import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { isRecordNotFoundError } from "../../prisma.util";
import * as errors from "../../errors";
import { Request } from "express";
import { plainToClass } from "class-transformer";
import { ApiNestedQuery } from "../../decorators/api-nested-query.decorator";
import * as nestAccessControl from "nest-access-control";
import * as defaultAuthGuard from "../../auth/defaultAuth.guard";
import { MyEntItyService } from "../myEntIty.service";
import { AclValidateRequestInterceptor } from "../../interceptors/aclValidateRequest.interceptor";
import { AclFilterResponseInterceptor } from "../../interceptors/aclFilterResponse.interceptor";
import { MyEntItyCreateInput } from "./MyEntItyCreateInput";
import { MyEntIty } from "./MyEntIty";
import { MyEntItyFindManyArgs } from "./MyEntItyFindManyArgs";
import { MyEntItyWhereUniqueInput } from "./MyEntItyWhereUniqueInput";
import { MyEntItyUpdateInput } from "./MyEntItyUpdateInput";

@swagger.ApiBearerAuth()
@common.UseGuards(defaultAuthGuard.DefaultAuthGuard, nestAccessControl.ACGuard)
export class MyEntItyControllerBase {
  constructor(
    protected readonly service: MyEntItyService,
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {}
  @common.UseInterceptors(AclValidateRequestInterceptor)
  @common.Post()
  @swagger.ApiCreatedResponse({ type: MyEntIty })
  @nestAccessControl.UseRoles({
    resource: "MyEntIty",
    action: "create",
    possession: "any",
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException,
  })
  async createMyEntIty(
    @common.Body() data: MyEntItyCreateInput
  ): Promise<MyEntIty> {
    return await this.service.createMyEntIty({
      data: data,
      select: {
        createdAt: true,
        fld1: true,
        id: true,
        updatedAt: true,
      },
    });
  }

  @common.UseInterceptors(AclFilterResponseInterceptor)
  @common.Get()
  @swagger.ApiOkResponse({ type: [MyEntIty] })
  @ApiNestedQuery(MyEntItyFindManyArgs)
  @nestAccessControl.UseRoles({
    resource: "MyEntIty",
    action: "read",
    possession: "any",
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException,
  })
  async myEntIties(@common.Req() request: Request): Promise<MyEntIty[]> {
    const args = plainToClass(MyEntItyFindManyArgs, request.query);
    return this.service.myEntIties({
      ...args,
      select: {
        createdAt: true,
        fld1: true,
        id: true,
        updatedAt: true,
      },
    });
  }

  @common.UseInterceptors(AclFilterResponseInterceptor)
  @common.Get("/:id")
  @swagger.ApiOkResponse({ type: MyEntIty })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  @nestAccessControl.UseRoles({
    resource: "MyEntIty",
    action: "read",
    possession: "own",
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException,
  })
  async myEntIty(
    @common.Param() params: MyEntItyWhereUniqueInput
  ): Promise<MyEntIty | null> {
    const result = await this.service.myEntIty({
      where: params,
      select: {
        createdAt: true,
        fld1: true,
        id: true,
        updatedAt: true,
      },
    });
    if (result === null) {
      throw new errors.NotFoundException(
        `No resource was found for ${JSON.stringify(params)}`
      );
    }
    return result;
  }

  @common.UseInterceptors(AclValidateRequestInterceptor)
  @common.Patch("/:id")
  @swagger.ApiOkResponse({ type: MyEntIty })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  @nestAccessControl.UseRoles({
    resource: "MyEntIty",
    action: "update",
    possession: "any",
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException,
  })
  async updateMyEntIty(
    @common.Param() params: MyEntItyWhereUniqueInput,
    @common.Body() data: MyEntItyUpdateInput
  ): Promise<MyEntIty | null> {
    try {
      return await this.service.updateMyEntIty({
        where: params,
        data: data,
        select: {
          createdAt: true,
          fld1: true,
          id: true,
          updatedAt: true,
        },
      });
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new errors.NotFoundException(
          `No resource was found for ${JSON.stringify(params)}`
        );
      }
      throw error;
    }
  }

  @common.Delete("/:id")
  @swagger.ApiOkResponse({ type: MyEntIty })
  @swagger.ApiNotFoundResponse({ type: errors.NotFoundException })
  @nestAccessControl.UseRoles({
    resource: "MyEntIty",
    action: "delete",
    possession: "any",
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException,
  })
  async deleteMyEntIty(
    @common.Param() params: MyEntItyWhereUniqueInput
  ): Promise<MyEntIty | null> {
    try {
      return await this.service.deleteMyEntIty({
        where: params,
        select: {
          createdAt: true,
          fld1: true,
          id: true,
          updatedAt: true,
        },
      });
    } catch (error) {
      if (isRecordNotFoundError(error)) {
        throw new errors.NotFoundException(
          `No resource was found for ${JSON.stringify(params)}`
        );
      }
      throw error;
    }
  }
}
