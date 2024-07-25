import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { MyEntItyServiceBase } from "./base/myEntIty.service.base";

@Injectable()
export class MyEntItyService extends MyEntItyServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
