<template lang="">
    <div class="item">
        <div class="item__icon" :class="`icon--${type}`"></div>
        <div class="item__content">
            <div class="content__title">{{ title }}</div>
            <div class="content__info">
                <div class="content__author">{{ authorName }}</div>
                <div class="content__response">
                    Đã trả lời: {{ totalResponse }}
                </div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    name: "DiscussListItem",
    props: {
        type: {
            type: String,
            required: true,
            default: "question",
        },
        title: {
            type: String,
            required: true,
            default: "Tiêu đề",
        },
        authorName: {
            type: String,
            required: true,
            default: "Tác giả",
        },
        totalResponse: {
            type: Number,
            required: true,
            default: 0,
        },
    },
    data() {
        return {};
    },
    methods: {},
    created() {},
    computed: {},
};
</script>
<style scoped>
.item {
    width: 100%;
    height: 50px;
    display: flex;
    column-gap: 12px;
    align-items: center;
    padding: 36px 0;
}
.item__icon {
    min-width: 50px;
    min-height: 50px;
    background-size: contain;
}

.icon--question {
    background-image: url(../../assets/icon/question-48.png);
}

.icon--discuss {
    background-image: url(../../assets/icon/discuss-32.png);
}

.icon--share {
    background-image: url(../../assets/icon/share-64.png);
}
.item__content {
}
.content__title {
    font-size: 16px;
    color: var(--color-primary);
    font-weight: bold;
}
.content__info {
    display: flex;
    column-gap: 30px;
    font-weight: bold;
}
.content__author {
}
.content__response {
}
</style>
