<template>
    <div class="container">
        <div class="discuss-detail">
            <div class="discuss-detail__title">
                Tiêu đề: Cần giúp đỡ về thuộc tính flex?
            </div>
            <div class="discuss-detail__author">
                <u><b>Người đăng:</b></u> Nguyễn Văn Mạnh
            </div>
            <div class="discuss-detail__content">
                "Hiển thị chi tiết nội dung câu hỏi/ chủ đề thảo luận. Sắp sếp
                theo thời gian gần nhất trước"
            </div>
            <div class="border-dashed"></div>
            <div class="action">
                <button class="discuss__response">Trả lời</button>
            </div>
        </div>
        <div class="response-list">
            <div class="response">
                <div class="response__title">
                    <div class="response__author">Nguyễn Văn Toàn</div>
                    <div class="response__date">(06:06:06 11/12/2001)</div>
                </div>
                <div class="response__content">
                    Khi click xem một câu hỏi bất kỳ.
                </div>
            </div>
            <div class="response">
                <div class="response__title">
                    <div class="response__author">Nguyễn Văn Toàn</div>
                    <div class="response__date">(06:06:06 11/12/2001)</div>
                </div>
                <div class="response__content">
                    Khi click xem một câu hỏi bất kỳ.
                </div>
            </div>
            <div class="response">
                <div class="response__title">
                    <div class="response__author">Nguyễn Văn Toàn</div>
                    <div class="response__date">(06:06:06 11/12/2001)</div>
                </div>
                <div class="response__content">
                    Khi click xem một câu hỏi bất kỳ.
                </div>
            </div>
            <div class="response">
                <div class="response__title">
                    <div class="response__author">Nguyễn Văn Toàn</div>
                    <div class="response__date">(06:06:06 11/12/2001)</div>
                </div>
                <div class="response__content">
                    Khi click xem một câu hỏi bất kỳ.
                </div>
            </div>
        </div>
        <button class="btn btn-primary">Quay lại</button>
    </div>
</template>
<script>
export default {
    name: "DiscussResponseDetail",
    props: {
        responseList: {
            type: Array,
            required: true,
            default: () => [],
        },
        disscusDetail: {
            type: Object,
            required: true,
            default: () => {},
        },
    },
    data() {
        return {};
    },
    methods: {},
    created() {},
};
</script>
<style scoped>
.container {
}
.discuss-detail {
}
.discuss-detail__title {
    font-size: 22px;
    font-weight: bold;
    padding-bottom: 8px;
}
.discuss-detail__author {
    padding-bottom: 8px;
    font-size: 14px;
}
.discuss-detail__content {
    font-size: 14px;
    padding-bottom: 14px;
}
.border-dashed {
    border-bottom: 1px dashed #eeeff1;
}

.action {
    width: 100%;
    height: 50px;
    display: flex;
    justify-content: flex-end;
    padding: 12px 0;
}
.discuss__response {
}
.response-list {
}
.response {
    font-size: 14px;
}
.response__title {
    display: flex;
    column-gap: 6px;
    font-weight: bold;
}
.response__author {
    color: var(--color-primary);
}
.response__date {
    color: #797a7b;
}
.response__content {
    padding-bottom: 16px;
}
</style>
