import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { DefServiceBase } from "./base/def.service.base";

@Injectable()
export class DefService extends DefServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
